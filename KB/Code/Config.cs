using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Threading;

namespace KB.Code
{
    public class Config
    {
        #region private
        private const char LIST_SEPARATOR = ';';
        private Configuration conf = null;
        private CultureInfo _Culture = Thread.CurrentThread.CurrentUICulture;
        private string _AutoDetectExeName = "";
        private bool _AutoStart = false;
        private bool _AutoDetect = false;
        private List<int> _IgnoredKeys = new List<int>();
        #endregion private

        #region get / set
        public CultureInfo Culture
        {
            get { return _Culture; }
            set { _Culture = value; Thread.CurrentThread.CurrentUICulture = _Culture; }
        }

        public string AutoDetectExeName
        {
            get { return _AutoDetectExeName; }
            set { _AutoDetectExeName = value; }
        }

        public bool AutoStart
        {
            get { return _AutoStart; }
            set { _AutoStart = value; }
        }

        public bool AutoDetect
        {
            get { return _AutoDetect; }
            set { _AutoDetect = value; }
        }

        public List<int> IgnoredKeys
        {
            get { return _IgnoredKeys; }
            set { _IgnoredKeys = value; }
        }
        #endregion get / set

        #region Singleton
        private static Config _Instance = null;
        private static readonly object _Padlock = new object();

        public static Config Current
        {
            get
            {
                try
                {
                    lock (_Padlock)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new Config();
                        }
                        return _Instance;
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        private Config()
        {
            conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            Load();
        }
        #endregion Singleton

        public void Save()
        {
            try
            {
                setConf("AutoDetectExeName", AutoDetectExeName);
                setConf("AutoStart", AutoStart.ToString());
                setConf("AutoDetect", AutoDetect.ToString());
                setConf("Culture", Culture.Name);
                setConf("IgnoredKeys", ConcatenateIntList(IgnoredKeys));

                conf.Save();
            }
            catch
            {
                throw;
            }
        }

        public void Load()
        {
            try
            {
                AutoDetectExeName = getConf("AutoDetectExeName");
                bool autoStart, autoDetect;
                if (bool.TryParse(getConf("AutoStart"), out autoStart) == true)
                    AutoStart = autoStart;
                if (bool.TryParse(getConf("AutoDetect"), out autoDetect) == true)
                    AutoDetect = autoDetect;
                string culture = getConf("Culture");
                if (culture != null)
                    Culture = new CultureInfo(culture);
                IgnoredKeys = ParseIntList(getConf("IgnoredKeys"));
            }
            catch
            {
                throw;
            }
        }

        #region utils
        protected void setConf(string key, string value)
        {
            try
            {
                if (conf.AppSettings.Settings[key] != null)
                    conf.AppSettings.Settings[key].Value = value;
                else
                    conf.AppSettings.Settings.Add(key, value);
            }
            catch
            {
                throw;
            }
        }

        protected string getConf(string key)
        {
            try
            {
                if (conf.AppSettings.Settings[key] != null)
                    return conf.AppSettings.Settings[key].Value;
                else
                    return null;
            }
            catch
            {
                throw;
            }
        }

        protected List<int> ParseIntList(string value)
        {
            try
            {
                if (value == null || value.Trim().Length == 0)
                    return new List<int>(0);

                string[] values = value.Split(LIST_SEPARATOR);
                List<int> ret = new List<int>(values.Length);

                foreach (string sint in values)
                {
                    int i;
                    if (int.TryParse(sint, out i) == true)
                        ret.Add(i);
                }

                return ret;
            }
            catch
            {
                throw;
            }
        }

        protected string ConcatenateIntList(IReadOnlyList<int> list)
        {
            try
            {
                string ret = "";
                foreach (int i in list)
                {
                    if (ret.Length > 0)
                        ret += LIST_SEPARATOR.ToString();
                    ret += i.ToString();
                }
                return ret;
            }
            catch
            {
                throw;
            }
        }
        #endregion utils
    }
}
