using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Food__Cour__Managemen__System
{
    public class SomeCommanFeiled:Management
    {
        public FileStream _FirstFile;
        public FileStream _SecondFile;
        public StreamReader _FirstReader;
        public StreamReader _SecondReader;
        public StreamWriter _FirstdWriter;
        public StreamWriter _SecondWriter;

        public void AddnewItem(string filename, ArrayList arrayList)
        {
            try
            {
                _FirstFile = new FileStream(filename, FileMode.Append, FileAccess.Write);
                _FirstdWriter = new StreamWriter(_FirstFile);
                for(int i = 0; i < arrayList.Count; i++)
                {
                    _FirstdWriter.Write(arrayList[i]+",");

                }
                _FirstdWriter.Write("\n");




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _FirstdWriter.Dispose(); 
                _FirstdWriter.Close();  
                _FirstFile.Close(); 


            }
            finally
            {
                _FirstdWriter.Dispose();
                _FirstdWriter.Close();
                _FirstFile.Close();

            }
        }

        public void ListAllItem(string filename)
        {
            try
            {
                _FirstFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
               _FirstReader = new StreamReader(_FirstFile);
                while (_FirstReader.Peek()>0)
                {
                    string lines=_FirstReader.ReadLine();
                    if(lines!="")
                    {
                        string[] data=lines.Split(',');
                        for(int i = 0; i < data.Length; i++)
                        {
                            Console.WriteLine("   "+data[i]+"  ");
                        }

                    }
                }


            }
            catch(Exception ex)
            {
               // Console.WriteLine(ex.Message);
                _FirstReader.Dispose();
                _FirstReader.Close();
                _FirstFile.Close();

            }
            finally
            {
                _FirstReader.Dispose();
                _FirstReader.Close();
                _FirstFile.Close();

            }
        }

        public void RemoveItem(int id, string filename)
        {
           
        }

        public void UpdateExistItem(int id, string name,ArrayList arrayList, string filename)
        {
            List<string> list = new List<string>();   
            try
            {
                _FirstFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
                _FirstReader = new StreamReader(_FirstFile);
                while (_FirstReader.Peek() > 0)
                {
                    string line=_FirstReader.ReadLine();
                    if (line != "")
                    {
                        list.Add(line);
                    }
                   
                }
                _FirstReader.Dispose();
                _FirstReader.Close();
                _FirstFile.Close();
                _FirstFile = new FileStream(filename, FileMode.Open, FileAccess.Write);
                _FirstdWriter=new StreamWriter(_FirstFile);
                for(int i = 0; i < list.Count; i++)
                {
                    string lines=list[i].ToString();
                    Console.WriteLine(lines);
                   
                        string[] arr=lines.Split(',');  
                        if(Convert.ToInt32(arr[0])==id && arr[1].ToString() == name)
                        {
                            for(int j = 0; j < arrayList.Count; j++)
                            {
                                _FirstdWriter.Write(arrayList[j].ToString()+",");
                                Console.WriteLine(arrayList[j]);
                            }
                            
                        }
                        else
                        {
                            _FirstdWriter.Write(lines);
                            Console.WriteLine("insise");
                        }
                    }
                    _FirstdWriter.Write("\n");
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _FirstdWriter.Dispose();
                _FirstdWriter.Close();
                _FirstFile.Close();

            }
            finally
            {
                _FirstdWriter.Dispose();
                _FirstdWriter.Close();
                _FirstFile.Close();

            }
        }

        public void ViewDetailsOfItems(int id, string name, string filename)
        {
            try
            {
                _FirstFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
                _FirstReader = new StreamReader(_FirstFile);
                while (_FirstReader.Peek() > 0)
                {
                    string lines = _FirstReader.ReadLine();
                    if (lines != "")
                    {
                        string[] data = lines.Split(',');
                        if(data[1]==name&& Convert.ToInt32(data[0])==id)
                        {
                            for (int i = 0; i < data.Length; i++)
                            {
                                Console.WriteLine("     "+data[i] + "  ");
                            }
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _FirstReader.Dispose();
                _FirstReader.Close();
                _FirstFile.Close();

            }
            finally
            {
                _FirstReader.Dispose();
                _FirstReader.Close();
                _FirstFile.Close();

            }

        }
        public void oldTonew(string oldname,string newname,string filename)
        {

            List<string> list = new List<string>();
            try
            {
                _FirstFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
                _FirstReader = new StreamReader(_FirstFile);
                while (_FirstReader.Peek() > 0)
                {
                    string line = _FirstReader.ReadLine();
                    if (line != "")
                    {
                        list.Add(line);
                    }

                }
                _FirstdWriter.Dispose();
                _FirstdWriter.Close();
                _FirstFile.Close();
                _FirstFile = new FileStream(filename, FileMode.Open, FileAccess.Write);
                _FirstdWriter = new StreamWriter(_FirstFile);
                for (int i = 0; i < list.Count; i++)
                {
                    string line = list[i];
                    if (line != "")
                    {
                        string[] arr = line.Split(',');
                        if (arr[2] == oldname)
                        {
                            arr[1] = newname;
                            for (int j = 0; j < arr.Length; j++)
                            {
                                _FirstdWriter.Write(arr[j] + ",");
                            }

                        }
                        else
                        {
                            _FirstdWriter.Write(line);
                        }
                    }
                    _FirstdWriter.Write("\n");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _FirstdWriter.Dispose();
                _FirstdWriter.Close();
                _FirstFile.Close();

            }
            finally
            {
                _FirstdWriter.Dispose();
                _FirstdWriter.Close();
                _FirstFile.Close();

            }

        }
    }
}
