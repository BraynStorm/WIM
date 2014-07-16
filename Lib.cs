using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WoW_Instance_Manager
{
    public class Instance
    {
        public String wowExePath;
        public String realmlistPath;
        public int n;

        public Instance(String wowExePath, String realmlistPath)
        {
            this.wowExePath = wowExePath;
            this.realmlistPath = realmlistPath;
        }
    }

    public class Realmlist
    {
        public String name;
        public String address;

        public Realmlist(String name, String address)
        {
            this.name = name;
            this.address = address;
        }

        override public String ToString()
        {
            return name;
        }
    }

    public class CFG
    {
        public String filepath;
        public String data;

        //Dictionary<int,CFGUtil> buffer = new Dictionary<int,CFGUtil>();
        List<CFGUtil> buffer = new List<CFGUtil>();
        

        bool lastWasBuffer = false;


        public void bufferData(String a, String b, String c)
        {

            if (!lastWasBuffer)
            {
                dumpBuffer();

                lastWasBuffer = true;
            }
            CFGUtil l = new CFGUtil();
            l.a = a;
            l.b = b;
            l.c = c;
            
            buffer.Add(l);
        }

        public CFG(String path)
        {
            filepath = path;
        }

        public void dumpBuffer()
        {
            buffer.Clear();
            Console.WriteLine("DUMPINNGGGGG");
        }


        public void save(String sectionName){
            lastWasBuffer = false;
            data += "[" + sectionName + "]" + System.Environment.NewLine;

            foreach (CFGUtil entry in buffer)
            {
                data += entry.a + ";" + entry.b + ";" + entry.c + System.Environment.NewLine;
            }
        }
        public void save_do()
        {
            System.IO.File.WriteAllText(filepath, data);
        }
        public List<CFGUtil> loadCFG(String sectionName)
        {
            dumpBuffer();
            lastWasBuffer = false;
            if(!File.Exists(filepath))
                return new List<CFGUtil>();

            String[] lines = File.ReadAllLines(filepath);
            
            bool sectionFound = false;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("[" + sectionName) && !sectionFound)
                {
                    sectionFound = true;
                    continue;
                }

                if (lines[i].StartsWith("[") && sectionFound)
                    return buffer;

                if (sectionFound)
                {
                    CFGUtil r = new CFGUtil();
                    String[] t = lines[i].Split(";".ToCharArray(), 3, StringSplitOptions.None);
                    r.a = t[0];
                    r.b = t[1];
                    r.c = t[2];
                    buffer.Add(r);
                }
            }
            return buffer;
        }
    }

    public class CFGUtil{
        public String a;
        public String b;
        public String c;
    }
}
