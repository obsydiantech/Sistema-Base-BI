using System;
using System.IO;

namespace Sistema_Base_BI.Managers
{
    public class NamesPathsManager // Singleton
    {
        // |---------------Atributos---------------|
        private static NamesPathsManager instance;
        public static NamesPathsManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new NamesPathsManager();

                return instance;
            }
        }

        public String SYSTEM_NAME;
        public String SYSTEM_ROOT_FOLDER;
        public String ERROR_LOGS_FILEPATH;
        public String CONFIG_FILEPATH;
        public String DESKTOP_PATH;

        // |---------------Constructores---------------|
        private NamesPathsManager()
        {
            SYSTEM_NAME = "Sistema Base";
            SYSTEM_ROOT_FOLDER = "C:/Program Files (x86)/" + SYSTEM_NAME + "/";
            ERROR_LOGS_FILEPATH = SYSTEM_ROOT_FOLDER + "error_logs.txt";
            CONFIG_FILEPATH = SYSTEM_ROOT_FOLDER + "config.txt";
            DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        // |---------------Métodos Públicos---------------|
        public void Init()
        {
            if (!Directory.Exists(SYSTEM_ROOT_FOLDER))
                CreateDirectoriesAndFiles();
        }

        // |---------------Métodos Privados---------------|
        private void CreateDirectoriesAndFiles()
        {
            CreateRootDirectory();

            CreateErrorLogsFile();

            CreateConfigFile();
        }

        private void CreateRootDirectory()
        {
            Directory.CreateDirectory(SYSTEM_ROOT_FOLDER);
        }

        private void CreateErrorLogsFile()
        {
            File.Create(ERROR_LOGS_FILEPATH);
        }

        private void CreateConfigFile()
        {
            File.Create(CONFIG_FILEPATH);
        }
    }
}