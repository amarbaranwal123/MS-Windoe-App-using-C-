using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string temp = "";
        int i = 0;
        int x = 0;
        int y = 0;
        List<List<string>> arr = new List<List<string>>();
        ArrayList result = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int m = 0;
            arr.Add(new List<string>()); //adds a new list to your list of lists

            if (arr.Count == 1)
            {
                arr[i].Add(txtName.Text); //adds a string to the first list
                arr[i].Add(txtAge.Text); //adds a string to the first list
                arr[i].Add(txtMath.Text); //adds a string to the first list
                arr[i].Add(txtPhysics.Text); //adds a string to the first list   
                i++;
            }
            else
            {
                while (m < arr.Count-1)
                {
                    if (arr[m][0]==txtName.Text   && arr[m][1] == txtAge.Text   && arr[m][2]== txtMath.Text &&  arr[m][3]== txtPhysics.Text)
                    {
                        MessageBox.Show("Data Already Available");
                       // --i;
                        break;
                    }
                   
                    m++;
                }
                arr[i].Add(txtName.Text); //adds a string to the first list
                arr[i].Add(txtAge.Text); //adds a string to the first list
                arr[i].Add(txtMath.Text); //adds a string to the first list
                arr[i].Add(txtPhysics.Text); //adds a string to the first list
                i++;
            }
            

            txtName.Text = "";
            txtAge.Text = "";
            txtMath.Text = "";
            txtPhysics.Text = "";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void topper_Click(object sender, EventArgs e)
        {
            int m=0;
            int index = 0;
            dynamic num1;
            dynamic num2;

            while (m<arr.Count)
            {
                num1 = arr[m][2];
                num2 = arr[m][3];
                dynamic num = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                result.Insert(index++,num);
                m++;
            }
 
            for (m = 1; m < result.Count; m++)
            {
                x =   Convert.ToInt32(result[m-1]);
                y =  Convert.ToInt32(result[m]); 
                if (x > y)
                {
                    temp = arr[m-1][0];
                }
            }
            txtResult.Text = temp.ToString();
        }       
    }
}

/*
 namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string temp = "";
        int i = 0;
        string[][] jArray = new string[5][];
        int[] result = new int[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            jArray[i++] = new string[4] { txtName.Text, txtAge.Text, txtMath.Text, txtPhysics.Text };
            MessageBox.Show((jArray.Length).ToString());
            // MessageBox.Show("Data Inserted on index : "+ i.ToString());


            txtName.Text = "";
            txtAge.Text = "";
            txtMath.Text = "";
            txtPhysics.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void topper_Click(object sender, EventArgs e)
        {
            int m = 0;
            dynamic num1;
            dynamic num2;

            while (m<jArray.Length)
            {
                num1 =jArray[m][2];
                num2 =jArray[m][3];
                result[m] = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                m++;
            }
            temp = jArray[0][0];
            for (m = 1; m < result.Length; m++)
            {
                if (result[m - 1] < result[m])
                {
                    temp = jArray[m][0];
                }
            }
            txtResult.Text = temp.ToString();
        }       
    }
}

 */

/*
  result[0] = Convert.ToInt32(jArray[0][2]) + Convert.ToInt32(jArray[0][3]);
            result[1] = Convert.ToInt32(jArray[1][2]) + Convert.ToInt32(jArray[1][3]);
            result[2] = Convert.ToInt32(jArray[2][2]) + Convert.ToInt32(jArray[2][3]);
            temp = jArray[0][0];
            for (int m = 1; m < 3; m++)
            {
                if (result[m - 1] < result[m])
                {
                    temp = jArray[m][0];
                }
            }
            txtResult.Text = temp.ToString();
            //MessageBox.Show("Topper is : " + temp.ToString());
 */

/*  string temp;
              int a = 0, b = 0;
              int num1 = 0,num2 = 0;
              double res1 = 0,res2=0, num3 = 0, num4 = 0;
              num1 = Convert.ToInt32(jArray[0][2]);
              num2 = Convert.ToInt32(jArray[0][3]);
              res1 = num1 + num2;
              for (a=1;a<jArray.Length;a++)
              {
                  for(b=2;b<jArray[a].Length;b++)
                  {
                      num3 = Convert.ToDouble(jArray[a][2]);
                      num4 = Convert.ToDouble(jArray[a][3]);
                      res2 = num3 + num4;
                      if (res1>res2)
                      {
                          temp = jArray[a - 1][0];
                          continue;
                      }
                      else
                      {
                          temp = jArray[a][0];
                      }
                  }
              }


           int r = result.Max();
           txtResult.Text = r.ToString();

              */