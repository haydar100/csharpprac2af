using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace practicum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(num1Text.Text);
            int num2 = Int32.Parse(num2Text.Text);
            int num3 = Int32.Parse(num3Text.Text);
            
            String output = MethodRunner.RunAllMethods(num1,num2,num3);
            methodOutput.Text = output;

            output = LambdaRunner.RunAllMethods(num1,num2,num3);
            lambdaOutput.Text = output;

            String[] lambdaOutputStrings = lambdaOutput.Text.ToString().Split('\n');
            String[] methodOutputStrings = methodOutput.Text.ToString().Split('\n');



            for (int i = 0; i < methodOutputStrings.Length - 1; i++)
            {
                string s = methodOutputStrings[i];
                s = s.Substring(s.LastIndexOf("=") + 2);
                methodOutputStrings[i] = s;

                // lambdaOutputStrings[i] = lambdaOutputStrings[i].Substring(lambdaOutputStrings[i].IndexOf("=") + 2, lambdaOutputStrings.Length -1);

            }

            //
           // Console.WriteLine(lambdaOutputStrings.Length.ToString());
            for (int i = 0; i < lambdaOutputStrings.Length -1 ; i++)
            {
                string s = lambdaOutputStrings[i];
               s = s.Substring(s.LastIndexOf("=") + 2);
                lambdaOutputStrings[i] = s;
                
                // lambdaOutputStrings[i] = lambdaOutputStrings[i].Substring(lambdaOutputStrings[i].IndexOf("=") + 2, lambdaOutputStrings.Length -1);

            }

         

            bool correct = true;

            for (int i = 0; i < lambdaOutputStrings.Length - 1; i++)
            {
                if (!lambdaOutputStrings[i].Equals(methodOutputStrings[i]))
                {
                    correct = false;
                    break;
                }
            }
           
         
          /*   string[] lambdaOutputTextToStringArray = Regex.Split(lambdaOutput.Text, (@"=")); // krijgt 9 elementen?
             string[] methodOutputTextToStringArray = methodOutput.Text.ToString().Split('='); // krijgt er ook 9 
             int[] convertMethodOutput = Array.ConvertAll<string, int>(lambdaOutputTextToStringArray, int.Parse);
             int[] convertLambdaOutput = Array.ConvertAll<string, int>(methodOutputTextToStringArray, int.Parse);
             if (convertMethodOutput.Equals(convertLambdaOutput))
             {
                MessageBox.Show("Results are OK !");
             }*/

            if (correct)
            {
                MessageBox.Show("outputs are equal");
            }
            else
            {
                MessageBox.Show("not equal");
            }
        

            // lijst maken en dan splitten en die 2 vergelijken ofzo. 




        }
    }
}
