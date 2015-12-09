namespace EveryDayNoteLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using UserControls;

    /// <summary>
    /// Video notes
    /// </summary>
    public class VideoNote : NotePart
    {
        public VideoPartUC vp = new VideoPartUC();
        public MediaElement Video;

        public override void Create()
        {
            this.ID = Guid.NewGuid();
            NoteParts.Add(this);
        }

        public override void Encrypt()
        {
        }

        public override void SetData()
        {
            Video = vp.Media;
        }

        public override UIElement RestoreData()
        {
            VideoPartUC VP = new VideoPartUC();
            VP.InitializeComponent();
            VP.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            VP.Media = Video;
            return VP;

        }
    }
}
