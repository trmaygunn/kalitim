using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_kapsamlı_ödev
{
    public static class sanaldatabase
    {
        private static ArrayList db=new ArrayList();
        

        public static void yeniurunekle(baseclass data)
        {
            if(data !=null &&  !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
            
        }
        public static bool dbbarkodkontrol(string barkod)
        {
            bool kontrolislem = false;
            if (db != null &&db.Count > 0)
            {
                for (int i = 0; i<db.Count;i++)
                {
                    baseclass bc = (baseclass)db[i];
                    if(bc.barkod== barkod)
                    {
                        kontrolislem = true;
                    }
                }
            }
            return kontrolislem;
        }
    }
}
