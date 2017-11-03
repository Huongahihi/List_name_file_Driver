using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace T
{
    class LietKe
    {
        private int count = 0;
      // private bool stop = false;

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        //public bool Stop
        //{
        //    get
        //    {
        //        return stop;
        //    }

        //    set
        //    {
        //        stop = value;
        //    }
        //}

        public void file(string dirpath, string keyword, TextBox text)
        {
           
            try
            {
                // một đối tượng có thể duyệt trên các thư mục con trực tiếp của thư mục dirpath.
                // nếu không có quyền truy cập thư mục 'dirpath'
                // một ngoại lệ unauthorizedaccessexception sẽ được ném ra.
                //IEnumerable<String> enums = Directory.EnumerateDirectories(dirpath);
                // danh sách
                //List<String> dirs = new List<String>(enums);               
                List<String> files = new List<String> (Directory.GetDirectories(dirpath, "*" + keyword + "*"));
                bool flag;
                foreach (var dir in files)
                {
                    flag = true;
                        for (int i = 0; i < dir.Length; i++)
                        {
                        if (dir[i].CompareTo('$') == 0)
                        {
                            flag = false;
                            break;
                        }                                 
                    }
                    if (!flag)
                    {
                        continue;
                    }
                    text.Text += dir + "\r\n";
                    // đệ quy tìm kiếm các thư mục con.
                    file(dir, keyword, text);
                    flag = true;
                    Count++;
                }
            }
            // lỗi khi truy cập vào thư mục không có quyền.
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Can not access directory: " + dirpath);
            }
        }

    }
}
