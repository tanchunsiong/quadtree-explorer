using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuadTreeExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private const string urlPattern = 
            "http://r1.ortho.tiles.virtualearth.net/tiles/r{0}.png?g=244&mkt=en-us&shading=hill";
        
        private void Go_Click(object sender, EventArgs e)
        {
            string url = string.Format(urlPattern, tbQuadTree.Text);

            webBrowser.Navigate(url);

            Utilities.Box result = Utilities.QuadKeyToBox(tbQuadTree.Text);

            tbBotLeft.Text = string.Format("{0},{1}",
                                            Utilities.YToLatitudeAtZoom(result.y * 256, 18),
                                            Utilities.XToLongitudeAtZoom(result.x * 256, 18));

            tbTopRight.Text = string.Format("{0},{1}",
                                            Utilities.YToLatitudeAtZoom((result.y - result.height) * 256, 18),
                                            Utilities.XToLongitudeAtZoom((result.x + result.width) * 256, 18));
            
            tbTopLeft.Text = string.Format("{0},{1}",
                                            Utilities.YToLatitudeAtZoom((result.y - result.height) * 256, 18),
                                            Utilities.XToLongitudeAtZoom((result.x) * 256, 18));
            tbBotRight.Text = string.Format("{0},{1}",
                                            Utilities.YToLatitudeAtZoom((result.y) * 256, 18),
                                            Utilities.XToLongitudeAtZoom((result.x + result.width) * 256, 18));

        }
        

    }
}
