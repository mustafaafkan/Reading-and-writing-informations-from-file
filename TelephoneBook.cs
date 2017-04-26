using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace astproject
{
    [Serializable]
    class TelephoneBook
    {
        
       
       
        private string tNumber;

        public string[] getTnumbers = new string[50];
        
        public string[] nlist = new string[50];

        public string[] nameArray = new string[50];

        public string this[int tnİndex]
        {
            get
            {
                return getTnumbers[tnİndex].ToString();
            }
            set
            {
                getTnumbers[tnİndex]=value;
                
            }
            
        }
        public void getNames(ArrayList a)
        {
            for(int i=0;i<a.Count;i++)
            {
                nameArray[i] = a[i].ToString();
            }
        }
       public void getNameAndTel(ArrayList a)
        {
           for(int i=0;i<a.Count;i++)
           {
               nlist[i] = a[i].ToString();
           }
        }
       // STREAM GOES HERE

        //*************************************************************
        public bool WriteToFile(string fileName,ArrayList list)
       {
            
           Stream s=null;
           BinaryFormatter bf;
            
            try
            {
                s = File.Create(fileName);
                bf = new BinaryFormatter();
                bf.Serialize(s, list);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            s.Close();
            return true;
            
            
       }

        public Array ReadFile(string fileName)
        {
            Stream s=null;
            BinaryFormatter bf;
            ArrayList a;
            
            s = File.OpenRead(fileName);
            bf = new BinaryFormatter();
            a = new ArrayList();
            a = (ArrayList)bf.Deserialize(s);
            a.TrimToSize();
            string[] write = new string[a.Count];
            for (int i = 0; i < a.Count;i++ )
            {
                write[i] = a[i].ToString();
            }
            


                s.Close();
            return write;
        }
        // STREAM FİNİSHES HERE
        //******************************************************************
        


        


    }
}
