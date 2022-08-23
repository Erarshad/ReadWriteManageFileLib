using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UtilityClass;

namespace FileManager
{

    interface IWriteManager
    {
        void writeApartmentData();
        void writeFamilyData();
        void writeVehicleData();
        void writeVisitorData();
    }
    class WriteManager
    {
        private List<IWriteManager> writers;
        private FileWriteManager filewriter;
        public string ap_no;
        public string line;
        Utility u = new Utility();
        public WriteManager(string ap_no, string line)
        {
            this.ap_no = ap_no;
            this.line = line;
            filewriter = new FileWriteManager();
            u.initializeFileStructure();
        }
        public void writeApartmentData()
        {
            filewriter.writeApartmentData(this.ap_no, this.line);
        }
        public void writeVisitorData()
        {
            filewriter.writeVisitorData(this.ap_no, this.line);
        }
        public void writeVehicleData()
        {
            filewriter.writeVehicleData(this.ap_no, this.line);
        }
        public void writeFamilyData()
        {

            filewriter.writeFamilyData(this.ap_no, this.line);

        }
    }
    class FileWriteManager
    {
        private string path { get; set; }
        private Utility utility { get; set; }
        public FileWriteManager()
        {
            utility = new Utility();
        }
        public void writeApartmentData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "AD");
            utility.writeToFilePath(path, line);
        }

        public void writeVisitorData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "RV");
            utility.writeToFilePath(path, line);
        }
        public void writeVehicleData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "VD");
            utility.writeToFilePath(path, line);
        }
        public void writeFamilyData(string ap_no, string line)
        {
            path = utility.getFilePath(ap_no, "FM");
            utility.writeToFilePath(path, line);
        }
    }

}
