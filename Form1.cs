using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using SpriteLibrary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SpriteController firstSprite;
        SpriteController secondSprite;
        SpriteController thirdSprite;
        private int nodeLifetime;
        private bool nodeIsAlive;
        private int currentCurrency;
        string RxString;
        private SerialPort bluetoothSerialPort;

        private byte[] deviceIDByte = new byte[4];
        private byte recvHR;

        private string id = "2403";

        private int commandCode;
        private int heartRate;

        public Form1()
        {
            bluetoothSerialPort = new SerialPort();
            bluetoothSerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            commandCode = 0;
            currentCurrency = 0;
            nodeLifetime = 10000;
            nodeIsAlive = true;
            for (int i = 0; i < id.Length; i++)
            {
                deviceIDByte[i] = (byte)id[i];
            }
            InitializeComponent();
            mainPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            speedShow.BackgroundImageLayout = ImageLayout.Stretch;
            mBox.BackgroundImageLayout = ImageLayout.Stretch;

            firstSprite = new SpriteController(mainPictureBox);
            secondSprite = new SpriteController(speedShow);
            thirdSprite = new SpriteController(mBox);

            Sprite character = new Sprite(new Point(0, 0), firstSprite,
                        Properties.Resources.s1, 37, 70, 200, 0);
            character.AddAnimation(new Point(0, 0), Properties.Resources.s1, 37, 70, 200, 4);
            character.AddAnimation(new Point(0, 0), Properties.Resources.s1, 37, 70, 100, 4);
            character.AddAnimation(new Point(0, 0), Properties.Resources.s1, 37, 70, 70, 4);
            character.SetName("character");
            character.SetSize(new Size(200, 100));
            character.AutomaticallyMoves = false;

            Sprite acter = new Sprite(new Point(0, 0), secondSprite,
                        Properties.Resources.speed, 36, 29, 200, 0);
            acter.SetName("speed");
            acter.SetSize(new Size(200, 100));
            acter.AutomaticallyMoves = false;
            acter.AddAnimation(new Point(40, 0), Properties.Resources.speed, 36, 29, 200, 0);
            acter.AddAnimation(new Point(80, 0), Properties.Resources.speed, 36, 29, 200, 0);
            acter.AddAnimation(new Point(120, 0), Properties.Resources.speed, 36, 29, 200, 0);
            acter.AddAnimation(new Point(160, 0), Properties.Resources.speed, 36, 29, 200, 0);
            acter.AddAnimation(new Point(200, 0), Properties.Resources.speed, 36, 29, 200, 0);
            acter.AddAnimation(new Point(240, 0), Properties.Resources.speed, 36, 29, 200, 0);
            acter.AddAnimation(new Point(280, 0), Properties.Resources.speed, 36, 29, 200, 0);
            acter.AddAnimation(new Point(320, 0), Properties.Resources.speed, 36, 29, 200, 0);


            acter = new Sprite(new Point(0, 0), thirdSprite, Properties.Resources.m,
                30, 30, 200, 0);
            acter.SetName("money");
            acter.SetSize(new Size(200, 100));
            acter.AutomaticallyMoves = false;
            acter.AddAnimation(new Point(30, 0), Properties.Resources.m, 30, 30, 200, 0);
            acter.AddAnimation(new Point(60, 0), Properties.Resources.m, 30, 30, 200, 0);
            acter.AddAnimation(new Point(90, 0), Properties.Resources.m, 30, 30, 200, 0);


            thirdSprite.SpriteFromName("money").PutBaseImageLocation(new Point(0, 0));
            secondSprite.SpriteFromName("speed").PutBaseImageLocation(new Point(0, 0));
            firstSprite.SpriteFromName("character").PutBaseImageLocation(new Point(0, 0));

           // thirdSprite.SpriteFromName("money").ChangeAnimation(3);
            //firstSprite.SpriteFromName("character").ChangeAnimation(1,2);
            // character.SpriteHitsPictureBox += SpriteBounces;

        }

        public int command
        {
            get { return commandCode; }
            set
            {
                if(value == 1)
                {
                    
                    if(heartRate > 100 && heartRate <= 110)
                    {
                        GatherNode(5);
                        firstSprite.SpriteFromName("character").ChangeAnimation(1);
                    }
                    else if (heartRate > 110 && heartRate <= 130)
                    {
                        GatherNode(10);
                        firstSprite.SpriteFromName("character").ChangeAnimation(2);
                    }
                    else if (heartRate > 130)
                    {
                        GatherNode(15);
                        firstSprite.SpriteFromName("character").ChangeAnimation(3);
                    }
                    else
                    {
                        firstSprite.SpriteFromName("character").ChangeAnimation(0);
                    }
                    commandCode = 0;
                    currency.Text = currentCurrency.ToString();
                    if (currentCurrency < 500)
                    {
                        thirdSprite.SpriteFromName("money").ChangeAnimation(0);
                    }
                    else if (currentCurrency < 800)
                    {
                        thirdSprite.SpriteFromName("money").ChangeAnimation(1);
                    }
                    else if (currentCurrency < 1200)
                    {
                        thirdSprite.SpriteFromName("money").ChangeAnimation(2);
                    }
                    else
                    {
                        thirdSprite.SpriteFromName("money").ChangeAnimation(3);
                    }
                }
            }
        }

        private void GatherNode(int rate)
        {
            if(nodeIsAlive)
            {
                nodeLifetime -= 1 * rate;
                currentCurrency += 1 * rate;
            }
            if(nodeLifetime <= 0)
            {
                nodeIsAlive = false;
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (bluetoothSerialPort.IsOpen)
            {
                bluetoothSerialPort.Close();
            }
        }

        private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
           try
            {
                RxString = bluetoothSerialPort.ReadLine();
                this.Invoke(new EventHandler(DisplayText));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
        private void DisplayText(object sender, EventArgs e)
        {
            bluetoothLbl.Text = RxString;
            int.TryParse(bluetoothLbl.Text, out heartRate);
            if (heartRate < 60)
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(0);
            }
            else if (heartRate <70)
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(1);
            }

            else if (heartRate<80)
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(2);
            }
            else if(heartRate<90)
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(3);
            }

            else if (heartRate<100)
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(4);
            }
            else if (heartRate < 110)
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(5);
            }
              else if (heartRate < 120)
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(6);
            }
            else if (heartRate < 130)
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(7);
            }
            else 
            {
                secondSprite.SpriteFromName("speed").ChangeAnimation(8);
            }
            command = 1;
        }

        private void scanPortsBtn_Click(object sender, EventArgs e)
        {
            comPorts.Items.Clear();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                comPorts.Items.Add(portName);
            }
            
        }

        private void comPortConnectBtn_Click(object sender, EventArgs e)
        {
            String serialPortName;
            if (comPorts.SelectedIndex != -1)
            {
                serialPortName = comPorts.Items[comPorts.SelectedIndex].ToString();
                try
                {
                    bluetoothSerialPort.BaudRate = 9600;
                    bluetoothSerialPort.PortName = serialPortName;
                    bluetoothSerialPort.Open();
                    if (bluetoothSerialPort.IsOpen)
                    {
                        serialConnectionState.Text = "Connected";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void testSendSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (bluetoothSerialPort.IsOpen)
                {
                    bluetoothSerialPort.WriteLine("CanSee");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
