using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DevExpress.Utils.Serializing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Customization;

namespace RibbonProject
{
    public static class RibbonSaveLoadLayoutHelperEx
    {
        public static void SaveLayoutToStream(RibbonControl control, Stream stream)
        {
            RunTimeRibbonTreeView tree = new RunTimeRibbonTreeView() { Ribbon = control };
            tree.CreateTree();
            RibbonCustomizationModel model = ResultModelCreator.Instance.Create(tree, control);

            try
            {
                XmlXtraSerializer serializer = new XmlXtraSerializer();
                GetApplicationName(model);
                serializer.SerializeObject(model, stream, GetApplicationName(model));
            }
            catch (Exception e)
            {
            }
        }
        public static void LoadLayoutFromStream(MyRibbonControl control, MemoryStream stream)
        {
            RibbonCustomizationModel model = null;
            try
            {
                model = new RibbonCustomizationModel(control);
                XmlXtraSerializer serializer = new XmlXtraSerializer();
                serializer.DeserializeObject(model, stream, GetApplicationName(model));

            }
            catch (Exception e)
            {
            }

            if (model == null || !model.IsModelValid(control))
                return;
            typeof(RibbonControl).GetMethod("ApplyCustomizationSettings", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(control, new object[] { model });
  
        }
        private static string GetApplicationName(RibbonCustomizationModel model)
        {
            return model.GetType().FullName;
        }
    }
}
