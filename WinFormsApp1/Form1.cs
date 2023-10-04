using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ListViewItem item;
        public Form1()
        {
            InitializeComponent();

            ProgramListExe(@"F:\Games");

            LoadProcessList();

            ListViewItem calculatorItem = new ListViewItem("Калькулятор");
            ListViewItem notepadItem = new ListViewItem("Блокнот");
            ListViewItem paintItem = new ListViewItem("Пеінт");
            ListViewItem paint3DItem = new ListViewItem("Пеінт 3D");


            listView2.Items.Add(calculatorItem);
            listView2.Items.Add(notepadItem);
            listView2.Items.Add(paintItem);
            listView2.Items.Add(paint3DItem);


        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                string selectedProgram = listView2.SelectedItems[0].Text;

                if (selectedProgram == "Калькулятор")
                {
                    Process.Start("calc.exe");
                }
                if (selectedProgram == "Блокнот")
                {
                    Process.Start("notepad.exe");
                }
                if (selectedProgram == "Пеінт")
                {
                    Process.Start("mspaint.exe");
                }
                if (selectedProgram == "Пеінт3Д")
                {
                    Process.Start("mspaint3d.exe");
                }

            }
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedProgramName = listView1.SelectedItems[0].Text;

                string programPath = Path.Combine(@"F:\Games", selectedProgramName + ".exe");

                if (File.Exists(programPath))
                {
                    try
                    {
                        Process.Start(programPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Файл не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadProcessList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                string selectedProcessName = listView3.SelectedItems[0].Text;

                Process[] processes = Process.GetProcessesByName(selectedProcessName);

                foreach (Process process in processes)
                {
                    try
                    {
                        process.CloseMainWindow();
                        if (!process.HasExited)
                        {
                            process.Kill();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LoadProcessList();
        }

        private void ProgramListExe(string directory)
        {
            try
            {

                string[] exeFiles = Directory.GetFiles(directory, "*.exe");

                foreach (var exeFile in exeFiles)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(exeFile));
                    listView1.Items.Add(item);
                }

                string[] subDirectories = Directory.GetDirectories(directory);
                foreach (var subDirectory in subDirectories)
                {
                    ProgramListExe(subDirectory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProcessList()
        {
            listView3.Items.Clear();
            Process[] processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                ListViewItem item = new ListViewItem(new string[] { process.ProcessName, process.Id.ToString() });
                listView3.Items.Add(item);
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView4.Items.Clear();

            if (listView3.SelectedItems.Count > 0)
            {
                string selectedProcess = listView3.SelectedItems[0].Text;

                Process[] processes = Process.GetProcesses();
                

                foreach (var processe in processes)
                {
                    if (selectedProcess == processe.ProcessName)
                    {
                        try
                        {

                            item = new ListViewItem("Назва:" + processe.ProcessName);
                            listView4.Items.Add(item);
    
                            item = new ListViewItem("Id:" + processe.Id);
                            listView4.Items.Add(item);

                            item = new ListViewItem("Time:" + processe.StartTime);
                            listView4.Items.Add(item);

                            item = new ListViewItem("Threads:" + processe.Threads.Count);
                            listView4.Items.Add(item);

                            item = new ListViewItem("Time work:" + processe.TotalProcessorTime);
                            listView4.Items.Add(item);

                            int processCount = Process.GetProcessesByName(processe.ProcessName).Length;
                            item = new ListViewItem("Count:" + processCount);
                            listView4.Items.Add(item);

                            break;
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadProcessList();
        }
    }
}