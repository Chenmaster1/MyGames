using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;

namespace MyGames
{
    class ListViewLogic
    {
        public void checkFile(ListView listView)
        {
            try
            {

                string[] lines = File.ReadAllLines("settings.txt");
                for (int i = 0; i < lines.Length;)
                {
                    Item item = new Item();
                    item.game = lines[i];
                    item.path = lines[i + 1];

                    var extractedIcon = System.Drawing.Icon.ExtractAssociatedIcon(item.path);

                    var bmSrc = Imaging.CreateBitmapSourceFromHIcon(
                            extractedIcon.Handle,
                            Int32Rect.Empty,
                            System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
                    extractedIcon.Dispose();

                    item.icon = bmSrc;

                    listView.Items.Add(item);

                    i += 2;
                }
            }
            catch (FileNotFoundException e)
            {
                File.Create("settings.txt");
            }
        }

        public void deleteGameFromView(ListView listView)
        {
            if (listView.SelectedIndex != -1)
            {


                string safe = File.ReadAllText("settings.txt");
                List<string> list = new List<string>();
                string temp = "";
                int i = 0;
                foreach (var letter in safe)
                {

                    if (letter.Equals('\n'))
                    {
                        i++;
                        list.Add(temp);
                        temp = "";
                    }
                    else if (letter.Equals('\r'))
                    {
                        i++;
                        continue;
                    }
                    else if (i + 1 == safe.Length)
                    {

                        list.Add(temp);
                    }
                    else
                    {
                        i++;
                        temp += letter;
                    }

                }

                if (listView.SelectedIndex == 0)
                {
                    list.RemoveAt(0);
                    list.RemoveAt(0);
                }
                else
                {
                    list.RemoveAt((listView.SelectedIndex * 2));
                    list.RemoveAt((listView.SelectedIndex * 2));
                }

                listView.Items.RemoveAt(listView.SelectedIndex);

                File.Delete("settings.txt");

                foreach (var entry in list)
                {
                    using (StreamWriter file =
                    new StreamWriter("settings.txt", true))
                    {
                        file.WriteLine(entry);
                        file.Close();
                    }
                }
            }
        }

        public void addGameToView(ListView listView)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "exe files (*.exe)|*.exe";

            if (ofd.ShowDialog() == true)
            {
                Item item = new Item();

                var extractedIcon = System.Drawing.Icon.ExtractAssociatedIcon(ofd.FileName);
                var bmSrc = Imaging.CreateBitmapSourceFromHIcon(
                            extractedIcon.Handle,
                            Int32Rect.Empty,
                            System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
                extractedIcon.Dispose();

                item.icon = bmSrc;
                item.game = Path.GetFileNameWithoutExtension(ofd.FileName);
                item.path = ofd.FileName;
                listView.Items.Add(item);

                using (StreamWriter file =
                    new StreamWriter("settings.txt", true))
                {
                    file.WriteLine(item.game);
                    file.WriteLine(item.path);
                }
            }

            double remainingSpace = listView.ActualWidth;
            (listView.View as GridView).Columns[1].Width = Math.Ceiling(remainingSpace);
        }

        public void startGameFromView(ListView listView)
        {
            try
            {
                if (listView.SelectedIndex != -1)
                {
                    Item item = (Item)listView.Items.GetItemAt(listView.SelectedIndex);
                    Process.Start(item.path);
                }
            }
            catch (System.ComponentModel.Win32Exception w)
            {

            }
        }

    }
}
