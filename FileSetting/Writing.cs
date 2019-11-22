using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Itc.FileSetting
{
    class Writing
    {
        public string Text;
        public string path;
        public string Ex;

        public void write()
        {
            StreamWriter wrt = new StreamWriter(this.path);
            try
            {
                wrt.Write(Text);
            }
            catch (Exception e)
            {
                Ex = e.Message;
            }
        }
       async public void writeAsync()
        {
            StreamWriter wrt = new StreamWriter(this.path);
            try
            {
              await  wrt.WriteAsync(Text);

            }catch(Exception e)
            {
                Ex = e.Message;
            }
        }
    }
}
