/*
 * 
 * El archivo que manda en la configuracion es 
 * W:\project_code\c_sharp\FastGest2\My-FyiReporting\FastGest\bin\Debug\MyLibrary.dll.config
 * En este archivo se lee/escribe el host i nombre de la base de datos a atacar.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using MyLibrary.Properties;
using System.Configuration;

namespace MyLibrary
{
    public class My
    {

        private static string sFullPath = System.Reflection.Assembly.GetAssembly(typeof(My)).Location;
        // Esto da la ruta --> "T:\\codi_font_distribuit\\FastGest2\\My-FyiReporting\\FastGest\\bin\\Debug\\MyLibrary.dll"
        // o la ruta --> "T:\\codi_font_distribuit\\FastGest2\\My-FyiReporting\\FastGest\\bin\\Release\\MyLibrary.dll"

        private static Configuration oCf = ConfigurationManager.OpenExeConfiguration(sFullPath);
        private static AppSettingsSection oApss = oCf.AppSettings;

        //oCf = ConfigurationManager.OpenExeConfiguration(sFullPath);

        //oApss = oCf.AppSettings;
        //private static string _TGestGenCS = MyLibrary.Properties.Settings.Default.TGestGenCS;  //Tal vez tendria que ser 
        //private static bool _conectado = MyLibrary.Properties.Settings.Default.Conectado;
        //private static string _server = MyLibrary.Properties.Settings.Default.Data Source;
        //private static bool _autoStart = MyLibrary.Properties.Settings.Default.AutoStart;
        //private static string _autoUser = MyLibrary.Properties.Settings.Default.AutoUser;
        //private static string _autoPassword = MyLibrary.Properties.Settings.Default.AutoPassword;
        //private static string _dtRelease = MyLibrary.Properties.Settings.Default.DtRelease;

        private static string _TGestGenCS = oApss.Settings["TGestGenCS"].Value;
        private static string _conectado = oApss.Settings["Conectado"].Value;
        private static string _data_Source = oApss.Settings["Data Source"].Value;//"192.168.177.20";
        //private static bool _bserver = (oApss.Settings["Data Source"].Value == "True")

        private static string _autoStart = oApss.Settings["AutoStart"].Value;
        private static string _autoUser = oApss.Settings["AutoUser"].Value;
        private static string _autoPassword = oApss.Settings["AutoPassword"].Value;
        private static string _dtRelease = oApss.Settings["DtRelease"].Value;
        private static string _productMajorPart = oApss.Settings["ProductMajorPart"].Value;
        private static string _productMinorPart = oApss.Settings["ProductMinorPart"].Value;
        private static string _productBuildPart = oApss.Settings["ProductBuildPart"].Value;
        private static string _installationType = oApss.Settings["InstallationType"].Value; 

        public My()
        {
            ////System.Reflection.Assembly.GetAssembly(typeof(DaoTests)).Location;
            //string sFullPath = System.Reflection.Assembly.GetAssembly(typeof (My)).Location;
            //oCf = ConfigurationManager.OpenExeConfiguration(sFullPath);

            //oApss = oCf.AppSettings;

            _TGestGenCS = oApss.Settings["TGestGenCS"].Value;
            _conectado = oApss.Settings["Conectado"].Value;


            _data_Source = oApss.Settings["Data Source"].Value;
            _autoStart = oApss.Settings["AutoStart"].Value;
            _autoUser = oApss.Settings["AutoUser"].Value;
            _autoPassword = oApss.Settings["AutoPassword"].Value;
            _dtRelease = oApss.Settings["DtRelease"].Value;

            _productMajorPart = oApss.Settings["ProductMajorPart"].Value;
            _productMinorPart = oApss.Settings["ProductMinorPart"].Value;
            _productBuildPart = oApss.Settings["ProductBuildPart"].Value;
            _installationType = oApss.Settings["InstallationType"].Value;


            //GestdbCS = MyLibrary.Properties.Settings.Default.TGestGenCS;
            //Conectado = MyLibrary.Properties.Settings.Default.Conectado;
            //Data Source = MyLibrary.Properties.Settings.Default.Data Source;
            //AutoStart = MyLibrary.Properties.Settings.Default.AutoStart;
            //AutoUser = MyLibrary.Properties.Settings.Default.AutoUser;
            //AutoPassword = MyLibrary.Properties.Settings.Default.AutoPassword;
            //DtRelease = MyLibrary.Properties.Settings.Default.DtRelease;

            //Escribir en el app.config
            //MyLibrary.Properties.Settings.Default.DtRelease = new DateTime().ToString();
        }


        ~My()
        {
            //Destructor
        }

        public static void SaveXml()
        {
            oApss.Settings["TGestGenCS"].Value = _TGestGenCS;
            oApss.Settings["Conectado"].Value = _conectado;
            oApss.Settings["Data Source"].Value = _data_Source;
            oApss.Settings["AutoStart"].Value = _autoStart;
            oApss.Settings["AutoUser"].Value = _autoUser;
            oApss.Settings["AutoPassword"].Value = _autoPassword;
            oApss.Settings["DtRelease"].Value = _dtRelease;

            oApss.Settings["ProductMajorPart"].Value = _productMajorPart;
            oApss.Settings["ProductMinorPart"].Value = _productMinorPart;
            oApss.Settings["ProductBuildPart"].Value = _productBuildPart;
            oApss.Settings["InstallationType"].Value = _installationType;

            oCf.Save(ConfigurationSaveMode.Modified);
        }

        public static string Data_Source
        {
            get { return _data_Source; }
            set { _data_Source = value; }
        }

        public static string TGestGenCS
        {
            get { return _TGestGenCS; }
            set { _TGestGenCS = value; }
        }

        public static string Conectado
        {
            get { return _conectado; }
            set { _conectado = value; }
        }

        public static string AutoStart
        {
            get { return _autoStart; }
            set { _autoStart = value; }
        }

        public static string AutoUser
        {
            get { return _autoUser; }
            set { _autoUser = value; }
        }

        public static string AutoPassword
        {
            get { return _autoPassword; }
            set { _autoPassword = value; }
        }

        public static string DtRelease
        {
            get { return _dtRelease; }
            set { _dtRelease = value; }
        }

        public static string ProductMajorPart
        {
            get { return _productMajorPart; }
            set { _productMajorPart = value; }
        }

        public static string ProductMinorPart
        {
            get { return _productMinorPart; }
            set { _productMinorPart = value; }
        }

        public static string ProductBuildPart
        {
            get { return _productBuildPart; }
            set { _productBuildPart = value; }
        }

        public static string InstallationType
        {
            get { return _installationType; }
            set { _installationType = value; }
        }
    }
}
