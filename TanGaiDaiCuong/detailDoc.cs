using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanGaiDaiCuong
{
    
    public partial class detailDoc : Form
    {

        public static Label lb_content, lb_title, lb_response;
        public static AxWindowsMediaPlayer video_player;
        public static detailDoc instance;

        public detailDoc()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            video_player = videoPlayer;
            lb_content = lbContent;
            lb_title = lbTitle;
            lb_response = lbResponse;
            instance = this;
        }

        public void displayDoc(Doc md)
        {
            md.display();
        }

        private void detailDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            video_player.Ctlcontrols.stop();
        }
    }
}
