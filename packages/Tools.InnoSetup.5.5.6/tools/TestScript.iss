; ��� ����������
#define   Name       "Every Day Note"
; ������ ����������
#define   Version    "0.0.1"
; �����-�����������
#define   Publisher  "mrVengr"
; ���� ����� ������������
; #define   URL        "http://www.miramishi.com"
; ��� ������������ ������
#define   ExeName    "EveryDayNote.exe"

;------------------------------------------------------------------------------
;   ��������� ���������
;------------------------------------------------------------------------------
[Setup]

; ���������� ������������� ����������, 
;��������������� ����� Tools -> Generate GUID
AppId={{69412080-8CB3-4F1E-934C-546F969B8E5E}

; ������ ����������, ������������ ��� ���������
AppName={#Name}
AppVersion={#Version}
AppPublisher={#Publisher}

; ���� ��������� ��-���������
DefaultDirName={pf}\{#Name}
; ��� ������ � ���� "����"
DefaultGroupName={#Name}

; �������, ���� ����� ������� ��������� setup � ��� ������������ �����
OutputDir=..\..\..\Setup
OutputBaseFileName=setup0.0.1

; ���� ������
; SetupIconFile=E:\work\Mirami\Mirami\icon.ico

; ��������� ������
Compression=lzma
SolidCompression=yes
;------------------------------------------------------------------------------
;   ������������� ����� ��� �������� ���������
;------------------------------------------------------------------------------
[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"; LicenseFile: "License_ENG.txt"
Name: "ru"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "License_RUS.txt"

;------------------------------------------------------------------------------
;   ����������� - ��������� ������, ������� ���� ��������� ��� ���������
;------------------------------------------------------------------------------
[Tasks]
; �������� ������ �� ������� �����
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
;------------------------------------------------------------------------------
;   �����, ������� ���� �������� � ����� �����������
;------------------------------------------------------------------------------
[Files]

; ����������� ����
Source: "..\..\..\EveryDayNote\bin\Release\EveryDayNote.exe"; DestDir: "{app}"; Flags: ignoreversion

; ������������� �������
Source: "..\..\..\EveryDayNote\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

; .NET Framework 4.5
Source: "dotNetFx45_Full_setup.exe"; DestDir: "{tmp}"; Flags: deleteafterinstall; Check: not IsRequiredDotNetDetected
;------------------------------------------------------------------------------
;   ��������� �����������, ��� �� ������ ����� ������
;------------------------------------------------------------------------------ 
[Icons]

; Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"

; Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: desktopicon
;------------------------------------------------------------------------------
;   ������ ���� ���������� �� ���������� �����
;------------------------------------------------------------------------------
[Code]
//-----------------------------------------------------------------------------
//  �������� ������� ������� ����������
//-----------------------------------------------------------------------------
function IsDotNetDetected(version: string; release: cardinal): boolean;

var 
    reg_key: string; // ��������������� ��������� ���������� �������
    success: boolean; // ���� ������� ������������� ������ .NET
    release45: cardinal; // ����� ������ ��� ������ 4.5.x
    key_value: cardinal; // ����������� �� ������� �������� �����
    sub_key: string;

begin

    success := false;
    reg_key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\';
    
    // ������ 3.0
    if Pos('v3.0', version) = 1 then
      begin
          sub_key := 'v3.0';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'InstallSuccess', key_value);
          success := success and (key_value = 1);
      end;

    // ������ 3.5
    if Pos('v3.5', version) = 1 then
      begin
          sub_key := 'v3.5';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', key_value);
          success := success and (key_value = 1);
      end;

     // ������ 4.0 ���������� �������
     if Pos('v4.0 Client Profile', version) = 1 then
      begin
          sub_key := 'v4\Client';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', key_value);
          success := success and (key_value = 1);
      end;

     // ������ 4.0 ����������� �������
     if Pos('v4.0 Full Profile', version) = 1 then
      begin
          sub_key := 'v4\Full';
          reg_key := reg_key + sub_key;
          success := RegQueryDWordValue(HKLM, reg_key, 'Install', key_value);
          success := success and (key_value = 1);
      end;

     // ������ 4.5
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
//  �������-������� ��� �������������� ���������� ������ ��� ������
//-----------------------------------------------------------------------------
function IsRequiredDotNetDetected(): boolean;
begin
    result := IsDotNetDetected('v4.5', 0);
end;
//-----------------------------------------------------------------------------
//    Callback-�������, ���������� ��� ������������� ���������
//-----------------------------------------------------------------------------
function InitializeSetup(): boolean;
begin

  // ���� ��� ��������� ������ .NET ������� ��������� � ���, ��� �����������
  // ���������� ���������� � �� ������ ���������
  if not IsDotNetDetected('v4.5', 0) then
    begin
      MsgBox('{#Name} requires Microsoft .NET Framework 4.5 Full Profile.'#13#13
             'The installer will attempt to install it', mbInformation, MB_OK);
    end;   

  result := true;
end;
[Run]
;------------------------------------------------------------------------------
;   ������ ������� ����� �����������
;------------------------------------------------------------------------------
Filename: {tmp}\dotNetFx45_Full_setup.exe; Parameters: "/q:a /c:""install /l /q"""; Check: not IsRequiredDotNetDetected; StatusMsg: Microsoft Framework 4.5 is installed. Please wait...