using System;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using System.IO;

namespace RibbonProject
{
    public partial class XtraForm1 : RibbonForm
    {
        private MemoryStream _Stream = new MemoryStream();
        public XtraForm1()
        {
            InitializeComponent();
            ribbonControl1.SaveLayoutToStream(_Stream);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _Stream.Seek(0, SeekOrigin.Begin);
            ribbonControl1.RestoreLayoutToStream(_Stream);
        }
    }
}