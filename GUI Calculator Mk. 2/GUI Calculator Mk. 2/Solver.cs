using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Calculator_Mk._2
{
    class Solver : ISolve
    {
        //fields
        string bottom = "";
        string top = "";

        //getters
        public string getTop()
        {
            return top;
        }
        public string getBottom()
        {
            return bottom;
        }

        //Accumulates the button pressed in the top half of the calculator
        public void Accumulate(string s)
        {
            top += s;
        }
        //Clears the current display (AC was pressed)
        public void Clear()
        {
            top = "";
            bottom = "";
        }
        //Solves the current top half of the display
        public double Solve(string s)
        {
            //creating variables
            double y = 0;
            string before, after, temp;
            int opInd = 0, beforeLen, afterLen;
            bool bNeg, aNeg;

            //looping through, switching adding a negative to subtraction, subtracting a negative to addition
            temp = "";
            for(int i = 0; i < s.Length;i++)
            {
                if (s[i] == '+' && s[i + 1] == '-')
                {
                    temp += '-';
                    i++;
                }
                else if (s[i] == '-' && s[i + 1] == '-')
                {
                    temp += '+';
                    i++;
                }
                else
                    temp += s[i];
            }
            s = temp;

            //doing math
            //loop through to do multiplication, division, and modular
            for(int i = 0; i < s.Length; i++)
            {
                //resetting variables
                before = "";
                after = "";
                bNeg = false;
                aNeg = false;
                beforeLen = 0;
                afterLen = 0;
                temp = "";
                opInd = 0;
                y = 0;

                //finding before
                for(int j = i; j < s.Length; j++)
                {
                    if (s[j] == '-' && j == i)
                    {
                        bNeg = true;
                    }
                    else if (s[j] == '*' || s[j] == '/' || s[j] == '+' || s[j] == '-' || s[j] == '%')
                    {
                        opInd = j;
                        j = s.Length;
                    }
                    else
                    {
                        before += s[j];
                        beforeLen++;
                    }
                }
                
                //finding after
                for(int j = opInd + 1; j < s.Length; j++)
                {
                    if (s[j] == '-' && j == opInd + 1)
                    {
                        aNeg = true;
                    }
                    else if (s[j] == '*' || s[j] == '/' || s[j] == '+' || s[j] == '-' || s[j] == '%')
                        j = s.Length;
                    else
                    {
                        after += s[j];
                        afterLen++;
                    }
                }
                //doing operation if multiplication or division
                if (s[opInd] == '*')
                {
                    double b = Convert.ToDouble(before);
                    double a = Convert.ToDouble(after);
                    if (bNeg)
                        b *= -1;
                    if (aNeg)
                        a *= -1;
                    y = b * a;

                    //replacing string
                    for(int j = 0; j < s.Length; j++)
                    {
                        if (j == i)
                        {
                            temp += y.ToString();
                            j += beforeLen + afterLen;
                            if (aNeg)
                                j++;
                            if (bNeg)
                                j++;
                        }
                        else if(s[j] != '-' || (j != i - 1 || j != opInd + 1))
                        {
                            temp += s[j];
                        }
                    }

                    //replacing s with temp
                    s = temp;
                    i--;
                }
                else if (s[opInd] == '/')
                {
                    double b = Convert.ToDouble(before);
                    double a = Convert.ToDouble(after);
                    if (bNeg)
                        b *= -1;
                    if (aNeg)
                        a *= -1;
                    y = b / a;

                    //replacing string
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (j == i)
                        {
                            temp += y.ToString();
                            j += beforeLen + afterLen;
                            if (aNeg)
                                j++;
                            if (bNeg)
                                j++;
                        }
                        else if (s[j] != '-' || (j != i - 1 || j != opInd + 1))
                        {
                            temp += s[j];
                        }
                    }

                    //replacing s with temp
                    s = temp;
                    i--;
                }
                else if (s[opInd] == '%')
                {
                    double b = Convert.ToDouble(before);
                    double a = Convert.ToDouble(after);
                    if (bNeg)
                        b *= -1;
                    if (aNeg)
                        a *= -1;
                    y = b % a;

                    //replacing string
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (j == i)
                        {
                            temp += y.ToString();
                            j += beforeLen + afterLen;
                            if (aNeg)
                                j++;
                            if (bNeg)
                                j++;
                        }
                        else if (s[j] != '-' || (j != i - 1 || j != opInd + 1))
                        {
                            temp += s[j];
                        }
                    }

                    //replacing s with temp
                    s = temp;
                    i--;
                }
            }
            //loop through to do addition and subtraction
            for (int i = 0; i < s.Length; i++)
            {
                //resetting variables
                before = "";
                after = "";
                bNeg = false;
                aNeg = false;
                beforeLen = 0;
                afterLen = 0;
                temp = "";
                opInd = 0;
                y = 0;

                //finding before
                for (int j = i; j < s.Length; j++)
                {
                    if (s[j] == '-' && j == i)
                    {
                        bNeg = true;
                    }
                    else if (s[j] == '*' || s[j] == '/' || s[j] == '+' || s[j] == '-' || s[j] == '%')
                    {
                        opInd = j;
                        j = s.Length;
                    }
                    else
                    {
                        before += s[j];
                        beforeLen++;
                    }
                }

                //finding after
                for (int j = opInd + 1; j < s.Length; j++)
                {
                    if (s[j] == '-' && j == opInd + 1)
                    {
                        aNeg = true;
                    }
                    else if (s[j] == '*' || s[j] == '/' || s[j] == '+' || s[j] == '-')
                        j = s.Length;
                    else
                    {
                        after += s[j];
                        afterLen++;
                    }
                }

                //doing operation if addition or subtraction
                if (s[opInd] == '+' && opInd != 0)
                {
                    double b = Convert.ToDouble(before);
                    double a = Convert.ToDouble(after);
                    if (bNeg)
                        b *= -1;
                    if (aNeg)
                        a *= -1;
                    y = b + a;

                    //replacing string
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (j == i)
                        {
                            temp += y.ToString();
                            j += beforeLen + afterLen;
                            if (aNeg)
                                j++;
                            if (bNeg)
                                j++;
                        }
                        else if (s[j] != '-' || (j != i - 1 || j != opInd + 1))
                        {
                            temp += s[j];
                        }
                    }

                    //replacing s with temp
                    s = temp;
                    i--;
                }
                else if (s[opInd] == '-' && opInd != 0)
                {
                    double b = Convert.ToDouble(before);
                    double a = Convert.ToDouble(after);
                    if (bNeg)
                        b *= -1;
                    if (aNeg)
                        a *= -1;
                    y = b - a;

                    //replacing string
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (j == i)
                        {
                            temp += y.ToString();
                            j += beforeLen + afterLen;
                            if (aNeg)
                                j++;
                            if (bNeg)
                                j++;
                        }
                        else if (s[j] != '-' || (j != i - 1 || j != opInd + 1))
                        {
                            temp += s[j];
                        }
                    }

                    //replacing s with temp
                    s = temp;
                    i--;
                }
                else
                    i = s.Length;
            }

            //returning r
            bottom = s;
            return Convert.ToDouble(s);
        }
    }
}


//nice