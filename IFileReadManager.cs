using FileManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal interface IFileReadManager
    {
       
        List<APVO> readAllData(string file_name);
        List<RVVO> readVisitorData(string ap_no);
        List<ADVO> readApartMentData(string ap_no);
        List<VDVO> readVehicleData(string ap_no);
        List<FMVO> readMembers(string ap_no);
    }
}
