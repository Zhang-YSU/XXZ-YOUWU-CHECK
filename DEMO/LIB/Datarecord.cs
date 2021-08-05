using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DEMO.LIB
{
    public class Datarecord
    {
        //模板的数据
        public void ALL_DATA_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("ALL_DATA_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void Boliditu_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("Boliditu_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K621Boliditu_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K621Boliditu_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void Boliset_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("Boliset.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K621Boliset_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K621Boliset.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void Zhijiaset_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("Zhijiaset.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K621Zhijiaset_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("Zhijiaset.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void PU_1_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("PU_1_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K621PU_1_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K621PU_1_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void PU_2_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("PU_2_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K621PU_2_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K621PU_2_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void PU_3_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("PU_3_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K621PU_3_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K621PU_3_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void Zhijiaditu_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("Zhijiaditu_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K621Zhijiaditu_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K621Zhijiaditu_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K612_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K612_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void BCK612_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("BCK612_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void BCK312_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("BCK312_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K312YP_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K312YP_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        public void K621YP_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K621YP_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        //铁片有无检测
        public void K621TPCheck_RecordWriteFile(string str)
        {
            //读写锁，当资源处于写入模式时，其他线程写入需要等待本次写入结束之后才能继续写入
            ReaderWriterLockSlim LogWriteLock = new ReaderWriterLockSlim();
            try
            {
                LogWriteLock.EnterWriteLock();
                StreamWriter sw = new StreamWriter("K621TPCheck_Record_file.txt", true, System.Text.Encoding.Default);
                sw.WriteLine(str);
                sw.Close();
            }
            catch
            {

            }
            finally
            {
                //退出写入模式，释放资源占用                
                LogWriteLock.ExitWriteLock();
            }
        }
        //

        //
        public List<string> Boliditu_Record_ReadFile()
        {
            FileStream fs = new FileStream("Boliditu_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K621Boliditu_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621Boliditu_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> Boliset_Record_ReadFile()
        {
            FileStream fs = new FileStream("Boliset.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K621Boliset_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621Boliset.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> Zhijiaset_Record_ReadFile()
        {
            FileStream fs = new FileStream("Zhijiaset.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 30; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K621Zhijiaset_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621Zhijiaset.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 30; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> PU_1_Record_ReadFile()
        {
            FileStream fs = new FileStream("PU_1_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K621PU_1_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621PU_1_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> PU_2_Record_ReadFile()
        {
            FileStream fs = new FileStream("PU_2_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K621PU_2_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621PU_2_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> PU_3_Record_ReadFile()
        {
            FileStream fs = new FileStream("PU_3_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K621PU_3_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621PU_3_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> Zhijiaditu_Record_ReadFile()
        {
            FileStream fs = new FileStream("Zhijiaditu_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K621Zhijiaditu_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621Zhijiaditu_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K612_Record_ReadFile()
        {
            FileStream fs = new FileStream("K612_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 18; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> BCK612_Record_ReadFile()
        {
            FileStream fs = new FileStream("BCK612_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 6; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> BCK312_Record_ReadFile()
        {
            FileStream fs = new FileStream("BCK312_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 10; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K312YP_Record_ReadFile()
        {
            FileStream fs = new FileStream("K312YP_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 10; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        public List<string> K621YP_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621YP_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 10; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }
        //铁片有无检测
        public List<string> K621TPCheck_Record_ReadFile()
        {
            FileStream fs = new FileStream("K621TPCheck_Record_file.txt", FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行  
            for (int i = 0; i < 2; i++)
            {
                string tmp = sr.ReadLine();
                list.Add(tmp);
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }

    }
}
