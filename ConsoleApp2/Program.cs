using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
                Calculator calculator = new Calculator();
                Console.WriteLine("请输入两个运算数或两个字符串：");
                String result = Console.ReadLine();
                String[] shu = result.Split(' ');
                calculator.A = shu[0];
                calculator.B = shu[1];
                Console.WriteLine("请输入运算符:加：“+”,减：“-”,乘：“*”,除：“/”:");
                string op = Console.ReadLine();
                Console.WriteLine("运算结果为：" + calculator.Calculate(op));
        }
    }
    class Calculator
    {
        int _a, _b;
        bool _statusA = true, _statusB = true;
        string _c, _d;
        public string A
        {
            set
            {
                try
                {
                    _a = int.Parse(value);
                }
                catch (FormatException e)
                {
                    _statusA = false;
                    _c = value;
                }
            }
        }
        public string B
        {
            set
            {
                try
                {
                    _b = int.Parse(value);
                }
                catch (FormatException e)
                {
                    _statusB = false;
                    _d = value;
                }
            }
        }
        public string Calculate(string op)
        {
            switch (op)
            {
                case "+":
                    if (_statusA && _statusB)
                    {
                        return (_a + _b) + "";
                    }
                    else if (_statusA && !_statusB)
                    {
                        _c = _a.ToString();
                        return (_c + _d).Replace("\"", "");
                    }
                    else if (!_statusA && _statusB)
                    {
                        _d = _b.ToString();
                        return (_c + _d).Replace("\"", "");
                    }
                    else
                    {
                        return (_c + _d).Replace("\"", "");
                    }
                case "-":
                    if (_statusA && _statusB)
                    {
                        return (_a - _b) + "";
                    }
                    else if (_statusA && !_statusB)
                    {
                        _c = _a.ToString();
                        return (_c.Replace(_d, "")).Replace("\"", "");
                    }
                    else if (!_statusA && _statusB)
                    {
                        _d = _b.ToString();
                        return (_c.Replace(_d, "")).Replace("\"", "");
                    }
                    else
                    {
                        return (_c.Replace(_d, "")).Replace("\"", "");
                    }
                case "*":
                    return (_a * _b) + "";
                case "/":
                        return ((float)_a / (float)_b) + "";
                default:
                    return "输入的运算符错误！";
            }
        }
    }
}

