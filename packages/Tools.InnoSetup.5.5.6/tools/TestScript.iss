; Имя приложения
#define   Name       "Every Day Note"
; Версия приложения
#define   Version    "0.0.1"
; Фирма-разработчик
#define   Publisher  "mrVengr"
; Сафт фирмы разработчика
; #define   URL        "http://www.miramishi.com"
; Имя исполняемого модуля
#define   ExeName    "EveryDayNote.exe"

;------------------------------------------------------------------------------
;   Параметры установки
;------------------------------------------------------------------------------
[Setup]

; Уникальный идентификатор приложения, 
;сгенерированный через Tools -> Generate GUID
AppId={{69412080-8CB3-4F1E-934C-546F969B8E5E}

; Прочая информация, отображаемая при установке
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}

; Путь установки по-умолчанию
DefaultDirName={pf}\{#Name}
; Имя группы в меню "Пуск"
DefaultGroupName={#Name}

; Каталог, куда будет записан собранный setup и имя исполняемого файла
OutputDir=..\..\..\Setup
OutputBaseFileName=setup0.0.1

; Файл иконки
; SetupIconFile=E:\work\Mirami\Mirami\icon.ico

; Параметры сжатия
Compression=lzma
SolidCompression=yes
;------------------------------------------------------------------------------
;   Устанавливаем языки для процесса установки
;------------------------------------------------------------------------------
[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"; LicenseFile: "License_ENG.txt"
Name: "ru"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "License_RUS.txt"

;------------------------------------------------------------------------------
;   Опционально - некоторые задачи, которые надо выполнить при установке
;------------------------------------------------------------------------------
[Tasks]
; Создание иконки на рабочем столе
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
;------------------------------------------------------------------------------
;   Файлы, которые надо включить в пакет установщика
;------------------------------------------------------------------------------
[Files]

; Исполняемый файл
Source: "..\..\..\EveryDayNote\bin\Release\EveryDayNote.exe"; DestDir: "{app}"; Flags: ignoreversion

; Прилагающиеся ресурсы
Source: "..\..\..\EveryDayNote\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

; .NET Framework 4.5
Source: "dotNetFx45_Full_setup.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall; Check: not IsRequiredDotNetDetected
;------------------------------------------------------------------------------
;   Указываем установщику, где он должен взять иконки
;------------------------------------------------------------------------------ 
[Icons]

; Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"

; Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: desktopicon
;------------------------------------------------------------------------------
;   Секция кода включенная из отдельного файла
;------------------------------------------------------------------------------
[Code]
//-----------------------------------------------------------------------------
//  Проверка наличия нужного фреймворка
//-----------------------------------------------------------------------------
function IsDotNetDetected(version: string; release: cardinal): boolean;

var 
    reg_key: string; // Просматриваемый подраздел системного реестра
    success: boolean; // Флаг наличия запрашиваемой версии .NET
    release45: cardinal; // Номер релиза для версии 4.5.x
    key_value: cardinal; // Прочитанное из реестра значение ключа
    sub_key: string;

begin

    success := false;
    reg_key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\';
    
    // Вресия 3.0
    if Pos('v3.0', version) = 1 then
      begin
          sub_key := 'v3.0';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'InstallSuccess', key_value);
          success := success and (key_value = 1);
      end;

    // Вресия 3.5
    if Pos('v3.5', version) = 1 then
      begin
          sub_key := 'v3.5';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', key_value);
          success := success and (key_value = 1);
      end;

     // Вресия 4.0 клиентский профиль
     if Pos('v4.0 Client Profile', version) = 1 then
      begin
          sub_key := 'v4\Client';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', key_value);
          success := success and (key_value = 1);
      end;

     // Вресия 4.0 расширенный профиль
     if Pos('v4.0 Full Profile', version) = 1 then
      begin
          sub_key := 'v4\Full';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', key_value);
          success := success and (key_value = 1);
      end;

     // Вресия 4.5
     if Pos('v4.5', version) = 1 then
      begin
          sub_key := 'v4.5\Full';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'Release', release45);
          success := success and (release45 >= release);
      end;
        
    result := success;

end;
//-----------------------------------------------------------------------------
//  Функция-обертка для детектирования конкретной нужной нам версии
//-----------------------------------------------------------------------------
function IsRequiredDotNetDetected(): boolean;
begin
    result := IsDotNetDetected('v4.5', 0);
end;
//-----------------------------------------------------------------------------
//    Callback-функция, вызываемая при инициализации установки
//-----------------------------------------------------------------------------
function InitializeSetup(): boolean;
begin

  // Если нет тербуемой версии .NET выводим сообщение о том, что инсталлятор
  // попытается установить её на данный компьютер
  if not IsDotNetDetected('v4.5', 0) then
    begin
      MsgBox('{#Name} requires Microsoft .NET Framework 4.5 Full Profile.'#13#13
             'The installer will attempt to install it', mbInformation, MB_OK);
    end;   

  result := true;
end;
[Run]
;------------------------------------------------------------------------------
;   Секция запуска после инсталляции
;------------------------------------------------------------------------------
Filename: {tmp}\dotNetFx45_Full_setup.exe; Parameters: "/q:a /c:""install /l /q"""; Check: not IsRequiredDotNetDetected; StatusMsg: Microsoft Framework 4.5 is installed. Please wait...