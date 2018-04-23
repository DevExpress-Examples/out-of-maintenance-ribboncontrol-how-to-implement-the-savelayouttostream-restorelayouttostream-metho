using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Customization;

namespace RibbonProject
{
    [System.ComponentModel.DesignerCategory("")]
    public class MyRibbonControl : RibbonControl
    {
        public MyRibbonControl()
        {

        }

        public void SaveLayoutToStream(Stream stream)
        {
            RibbonSaveLoadLayoutHelperEx.SaveLayoutToStream(this, stream);
        }
        public void RestoreLayoutToStream(MemoryStream stream)
        {
            RibbonSaveLoadLayoutHelperEx.LoadLayoutFromStream(this, stream);
        }
    }
}