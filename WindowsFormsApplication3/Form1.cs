using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            status.Text = "Введите терминалы";
        }
       public class P_element
        {
            public string leftSide;
            public string rightSide;
           public static bool Check_1(P_element[] P)
            {

                bool crutch = false;
                for (int i = 0; i < P.Length; i++)
                {
                    crutch = false;
                    for (int j = 0; j < P[i].leftSide.Length; j++)
                    {
                        if (P[i].leftSide[j].ToString() == P[i].leftSide[j].ToString().ToUpper())
                        {
                            crutch = true;
                        }
                    }
                    if (crutch == false)
                    {
                        return false;
                    }
                }
                return true;
            }
           public static bool Check_2(P_element[] P)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i].leftSide.Length > 1)
                    {
                        return false;
                    }
                }
                return true;
            }
           public static bool Check_3(P_element[] P)
            {
                bool crutch = false;
                for (int i = 0; i < P.Length; i++)
                {
                    crutch = false;
                    if ((P[i].rightSide != "e") && (P[i].rightSide[0].ToString() == P[i].rightSide[0].ToString().ToUpper()))
                    {
                        for (int j = 0; j < P[i].rightSide.Length; j++)
                        {
                            if (P[i].rightSide[j].ToString() != P[i].rightSide[j].ToString().ToUpper())
                            {
                                crutch = true;
                            }
                            if ((crutch == true) && (P[i].rightSide[j].ToString() == P[i].rightSide[j].ToString().ToUpper()))
                            {
                                return false;
                            }
                        }
                    }
                    crutch = false;
                    if ((P[i].rightSide != "e") && (P[i].rightSide[0].ToString() != P[i].rightSide[0].ToString().ToUpper()))
                    {
                        for (int j = 0; j < P[i].rightSide.Length; j++)
                        {
                            if (P[i].rightSide[j].ToString() == P[i].rightSide[j].ToString().ToUpper())
                            {
                                crutch = true;
                            }
                            if ((crutch == true) && (P[i].rightSide[j].ToString() != P[i].rightSide[j].ToString().ToUpper()))
                            {
                                return false;
                            }
                        }
                    }

                }
                return true;
            }
           public static bool Is_left(P_element[] P)
            {
                bool crutch = false;
                for (int i = 0; i < P.Length; i++)
                {
                    if ((P[i].rightSide.ToUpper() != P[i].rightSide) && (P[i].rightSide.ToLower() != P[i].rightSide))
                    {
                        if (P[i].rightSide[0].ToString() != P[i].rightSide[0].ToString().ToUpper())
                        {
                            crutch = true;
                        }
                    }
                }
                if (crutch == true) return false;
                if (crutch == false) return true;
                return false;
            }
           public static bool Is_right(P_element[] P)
            {
                bool crutch = false;
                for (int i = 0; i < P.Length; i++)
                {
                    if ((P[i].rightSide.ToUpper() != P[i].rightSide) && (P[i].rightSide.ToLower() != P[i].rightSide))
                    {
                        if (P[i].rightSide[P[i].rightSide.Length - 1].ToString() != P[i].rightSide[P[i].rightSide.Length - 1].ToString().ToUpper())
                        {
                            crutch = true;
                        }
                    }
                }
                if (crutch == true) return false;
                if (crutch == false) return true;
                return false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        char[] T;
        char[] N;
        char S;
        int ex_num = 0;
        P_element[] P;


        private void button1_Click(object sender, EventArgs e)
        {
            if ((status.Text == "Введите выражение: левую часть") && (Enter.Text != null))
            {
                status.Text = "Введите выражение";
                
            }
            if ((status.Text == "Введите правую часть выражения") && (Enter.Text != null))
            {
                P[ex_num].rightSide = Enter.Text;
                richTextBox1.Text = richTextBox1.Text + Enter.Text + "\n";
                ex_num++;
                if (ex_num < P.Length)
                {
                    status.Text = "Введите выражение: левую часть";
                    Enter.Text = null;
                }
                else
                {
                    status.Text="Ввод закончен";
                    Enter.Text = null;
                    button2.Visible = true;

                }
                


            }
            if ((status.Text == "Введите выражение") && (Enter.Text != null))
            {
                status.Text = "Введите выражение: левую часть";
                richTextBox1.Text = richTextBox1.Text + Enter.Text + " -> ";
                P[ex_num].leftSide = Enter.Text;
                status.Text = "Введите правую часть выражения";
                Enter.Text = null;
               
            }
            if ((status.Text == "Введите количество выражений") && (Enter.Text != null))
            {
               P=new P_element[int.Parse(Enter.Text)];
               for (int i = 0; i < int.Parse(Enter.Text); i++)
               {
                   P[i] = new P_element();
               }
               status.Text = "Введите выражение";
               richTextBox1.Visible = true;
               Enter.Text = null;
            }

            if ((status.Text == "Введите аксиому") && (Enter.Text != null))
            {
                Enter.Text = Enter.Text.ToUpper();
                bool crutch = true;
                if (Enter.Text.Length > 1)
                {
                    Enter.Text = null;
                    MessageBox.Show("Введите одну букву");
                    crutch = false;
                }
                if (crutch == true)
                {
                    S = Enter.Text[0];
                    textBox5.Visible = true;
                    S_box.Visible = true;
                    S_box.Text = Enter.Text;
                    Enter.Text = null;
                    status.Text = "Введите количество выражений";
                }
            }


            if ((status.Text == "Введите нетерминалы") && (Enter.Text != null))
            {
                Enter.Text=Enter.Text.ToUpper();
                bool crutch = true;
                N = new char[Enter.Text.Length];
                for (int i = 0; i < Enter.Text.Length; i++)
                {
                    for (int j = 0; j < Enter.Text.Length; j++)
                    {
                        if ((Enter.Text[i] == Enter.Text[j]) && (i != j))
                        {
                            Enter.Text = null;
                            N = null;
                            MessageBox.Show("Нетерминалы повторяются");
                            crutch = false;
                        }
                    }

                }
                if (crutch == true)
                {
                    N_box.Text = Enter.Text;
                    N_box.Visible = true;
                    textBox4.Visible = true;
                    status.Text = "Введите аксиому";
                    Enter.Text = null;
                }
            }

            if ((status.Text == "Введите терминалы") && (Enter.Text != null))
            {
                Enter.Text = Enter.Text.ToLower();
                bool crutch = true;
                T = new char[Enter.Text.Length];
                for (int i = 0; i < Enter.Text.Length; i++)
                {
                    for (int j = 0; j < Enter.Text.Length; j++)
                    {
                        if ((Enter.Text[i] == Enter.Text[j]) && (i != j))
                        {
                            Enter.Text = null;
                            T = null;
                            MessageBox.Show("Терминалы повторяются");
                            crutch = false;
                        }
                    }
                    
                }
                if (crutch==true)
                {
                    T_box.Text = Enter.Text;
                    T_box.Visible = true;
                    textBox1.Visible = true;
                    status.Text = "Введите нетерминалы";
                    Enter.Text = null;
                }
            }

            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (P_element.Check_1(P) == false)
            {
                MessageBox.Show("Тип 0");
            }
            else
            {
                if (P_element.Check_2(P) == false)
                {
                    MessageBox.Show("Тип 1");
                }
                else
                {
                    if (P_element.Check_3(P) == false)
                    {
                        MessageBox.Show("Тип 2");
                    }
                    else
                    {
                        if (P_element.Is_left(P) == true)
                        {
                            MessageBox.Show("Тип 3: левосторонняя");
                        }
                        else
                        {
                            if (P_element.Is_right(P) == true)
                            {
                                MessageBox.Show("Тип 3: правосторонняя");

                            }
                            else
                            {
                                MessageBox.Show("Тип 2");
                            }
                        }
                    }
                }
                    
            }
        }
    }
}
