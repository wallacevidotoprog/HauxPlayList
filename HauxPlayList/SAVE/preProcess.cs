using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HauxPlayList.SAVE
{
    public class preProcess
    {
        public preProcessConfigs PlayList;

        public preProcess(string NameP, string DescP, Image ImgP, MetroFramework.Controls.MetroGrid GridM,int modo,out bool finalizado, Exception Err)
        {
            finalizado = false;
            try
            {
                if (GridM.Rows.Count > 0)
                {

                    PlayList = new preProcessConfigs();

                    PlayList.NomePlayList = NameP;
                    PlayList.DescricaoPlayList = DescP;
                    PlayList.CapaPlayList = ImgP;

                    for (int i = 0; i < GridM.Rows.Count; i++)
                    {
                        string caminhos = GridM.Rows[i].Cells[GridM.ColumnCount - 1].Value.ToString();
                        if (File.Exists(caminhos))
                        {
                            string[] INFO = { GridM.Rows[i].Cells[1].Value.ToString(), caminhos };
                            PlayList.AddItem(INFO);

                        }

                    }

                    switch (modo)
                    {
                        case 0:
                            SalvarFile();
                            break;
                        default:
                            break;
                    }

                }
                finalizado = true;
            }
            catch (Exception ex)
            {
                
                Err = ex;
                finalizado = false;
            }
           

        }
        public void SalvarFile()
        {
            
            string pd = MainWindow.XmlDataConfigs.PastaBase;
            string pathString =Path.Combine(pd, PlayList.NomePlayList);
            Directory.CreateDirectory(pathString);

            for (int i = 0; i < PlayList.Files.Length; i++)
            {
               
                if (File.Exists(pathString + @"\" + (i + 1).ToString("000") + " - " + Path.GetFileName(PlayList.Files[i][0]) + Path.GetExtension(PlayList.Files[i][1])))
                {
                    File.Delete(pathString + @"\" + (i + 1).ToString("000") + " - " + Path.GetFileName(PlayList.Files[i][0]) + Path.GetExtension(PlayList.Files[i][1]));
                }                
                File.Copy(PlayList.Files[i][1], pathString + @"\" + (i + 1).ToString("000") + " - " + Path.GetFileName(PlayList.Files[i][0])+Path.GetExtension(PlayList.Files[i][1]));
                
            }
        }





    }
    public class preProcessConfigs
    {
        public string NomePlayList;
        public string DescricaoPlayList;
        public Image CapaPlayList;
        public string[][] Files;

        public void AddItem(string[] itemValues)
        {
            if (Files is null)
            {
                Array.Resize(ref Files, Files?.Length??0 + 1);
                Files[Files.Length - 1] = itemValues;
            }
            else
            {
                Array.Resize(ref Files, Files.Length + 1);
                Files[Files.Length - 1] = itemValues;
            }
            
        }

        public void RemoveItem(int itemIndex)
        {
            string[][] newValues = new string[Files.Length - 1][];
            Array.Copy(Files, 0, newValues, 0, itemIndex);
            int length = newValues.Length - itemIndex;
            Array.Copy(Files, itemIndex + 1, newValues, itemIndex, newValues.Length - itemIndex);
            Files = newValues;

        }

    }





}
