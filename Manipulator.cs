using EnigmaTrial1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace EnigmaManipulator
{
    class Manipulator
    {
        public static Settings Sett = new Settings();
        public static List<string> AllLines = new List<string>();
        public static int[] ringSelection = { 0, 0, 0 };
        public static int[] ringSettings = { 0, 0, 0 };
        public static char[,] rotors = new char[,] { };
        public static char[,] selectedRotors = new char[,] { };
        public static string ThisIsThePath = "";

        public static void MyReader(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                        AllLines.Add(line); 
                }
            }
            catch (Exception)
            {
                AllLines = new List<string>();
            }
        }

        public static int rotorCount()
        {
            return Splitter(AllLines[0], new char[] { ',' }).Length - 1;
        }

        public static int rotorContentCount()
        {
            return AllLines.Count;
        }

        public static void rotorSeparator()
        {
            rotors = new char[rotorContentCount(), rotorCount() + 1];
            for (int x = 0; x < rotorContentCount(); x++)
            {
                string[] elements = Splitter(AllLines[x], new char[] { ',' });
                for (int y = 0; y < rotorCount() + 1; y++)
                {
                    rotors[x, y] = stringToChar(elements[y]);
                }
            }
        }

        public static void ringSelectionCounter(int index, char buttonFunction)
        {
            switch (buttonFunction)
            {
                case '+':
                    ringSelection[index]++;
                    if (ringSelection[index] > rotorCount() - 1)
                        ringSelection[index] = 0;
                    break;
                case '-':
                    ringSelection[index]--;
                    if (ringSelection[index] < 0)
                        ringSelection[index] = rotorCount() - 1;
                    break;
            }
        }

        public static void ringSettingsCounter(int index, char buttonFunction)
        {
            switch (buttonFunction)
            {
                case '+':
                    ringSettings[index]++;
                    if (ringSettings[index] > rotorContentCount() - 1)
                        ringSettings[index] = 0;
                    break;
                case '-':
                    ringSettings[index]--;
                    if (ringSettings[index] < 0)
                        ringSettings[index] = rotorContentCount() - 1;
                    break;
            }
        }

        public static void rotorOffset()
        {
            int index = 0;
            selectedRotors = new char[rotorContentCount(), 3];

            for (int x = 0; x < rotorContentCount(); x++)
            {
                index = x + ringSettings[0];
                if (index >= rotorContentCount())
                    index = index % rotorContentCount();

                selectedRotors[x, 0] = rotors[index, ringSelection[0] + 1];
            }
            for (int x = 0; x < rotorContentCount(); x++)
            {
                index = x + ringSettings[1];
                if (index >= rotorContentCount())
                    index = index % rotorContentCount();

                selectedRotors[x, 1] = rotors[index, ringSelection[1] + 1];
            }

            for (int x = 0; x < rotorContentCount(); x++)
            {
                index = x + ringSettings[2];
                if (index >= rotorContentCount())
                    index = index % rotorContentCount();

                selectedRotors[x, 2] = rotors[index, ringSelection[2] + 1];
            }
        }

        public static void rotatingRotors()
        {
            ringSettings[0]++;
            if (ringSettings[0] > rotorContentCount() - 1)
            {
                ringSettings[0] = 0;
                ringSettings[1]++;
                if (ringSettings[1] > rotorContentCount() - 1)
                {
                    ringSettings[1] = 0;
                    ringSettings[2]++;
                    if (ringSettings[2] > rotorContentCount() - 1)
                    {
                        ringSettings[2] = 0;
                    }
                }
            }
            rotorOffset();
        }

        public static char encryptedOutput(char input)
        {
            char output = '\0';

            int x = 0;
            for (x = 0; x < rotorContentCount(); x++)
            {
                if (input == rotors[x, 0])
                {
                    output = selectedRotors[x, 0];
                    break;
                }
            }

            int y = 0;
            for (y = 0; y < rotorContentCount(); y++)
            {
                if (selectedRotors[x, 0] == rotors[y, 0])
                {
                    output = selectedRotors[y, 1];
                    break;
                }
            }

            int z = 0;
            for (z = 0; z < rotorContentCount(); z++)
            {
                if (selectedRotors[y, 1] == rotors[z, 0])
                {
                    output = selectedRotors[z, 2];
                    break;
                }
            }
            rotatingRotors();
            return output;
        }

        public static string[] Splitter(string stringToSplit, char[] splitChars)
        {
            return stringToSplit.Split(splitChars);
        }

        private static char stringToChar(string a)
        {
            return Convert.ToChar(Convert.ToInt32(a));
        }
    }
}
