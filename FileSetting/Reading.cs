using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Itc.FileSetting
{
    class Reading
    {
        public string Text ="";
        public string Exception_message;
        public void read(string path)
        {
            try {
                StreamReader rea = new StreamReader(path)
             ;
                Text = rea.ReadToEnd();
                Exception_message = null;
            }
            catch (Exception ex )
            {
                this.Exception_message = ex.Message;
                Text = null; 
            }
            }

        async public void readasync(string path)
        {
            StreamReader rea = new StreamReader(path);
            try
            {
                Text = await rea.ReadToEndAsync();

                Exception_message = null;
            }catch(Exception ex)
            {
                Exception_message = ex.Message;
                Text
                    = null;
            }
        }

    }
}
