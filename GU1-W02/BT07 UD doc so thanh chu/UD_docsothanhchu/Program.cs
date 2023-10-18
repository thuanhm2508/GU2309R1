using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace UD_docsothanhchu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = -1;
            int luotdem = 3;
            Console.InputEncoding = Encoding.Unicode;       // Nhập vào định dạng Unicode
            Console.OutputEncoding = Encoding.Unicode;      // Xuất ra màn hình định dạng Unicode
            // Nhập số ..
            Console.Write("Nhập số muốn đọc: ");
            //Console.Write(int.TryParse(Console.ReadLine(), out a));
            bool docso = int.TryParse(Console.ReadLine(), out a);
            if (docso)
            {

                if (docso && a >= 0 && a <= 99)
                {
                    if (a == 0)
                    {
                        Console.WriteLine("Zero");
                        return;
                    }
                    if (a >= 0 && a < 10)
                    {
                        switch (a)
                        {
                            case 1: Console.WriteLine("one"); break;
                            case 2: Console.WriteLine("two"); break;
                            case 3: Console.WriteLine("three"); break;
                            case 4: Console.WriteLine("four"); break;
                            case 5: Console.WriteLine("five"); break;
                            case 6: Console.WriteLine("six"); break;
                            case 7: Console.WriteLine("seven"); break;
                            case 8: Console.WriteLine("eight"); break;
                            case 9: Console.WriteLine("nine"); break;

                        }
                    }
                    if (a >= 11 && a < 20)
                    {
                        switch (a)
                        {
                            case 11: Console.WriteLine("eleven"); break;
                            case 12: Console.WriteLine("twelve"); break;
                            case 13: Console.WriteLine("thirteen"); break;
                            case 14: Console.WriteLine("fourteen"); break;
                            case 15: Console.WriteLine("fifteen"); break;
                            case 16: Console.WriteLine("sixteen"); break;
                            case 17: Console.WriteLine("seventeen"); break;
                            case 18: Console.WriteLine("eighteen"); break;
                            case 19: Console.WriteLine("nineteen"); break;
                        }
                    }
                    if (a % 10 == 0)
                    {
                        switch (a)
                        {
                            case 10: Console.WriteLine("ten"); break;
                            case 20: Console.WriteLine("twenty"); break;
                            case 30: Console.WriteLine("thirty"); break;
                            case 40: Console.WriteLine("fourty"); break;
                            case 50: Console.WriteLine("fifty"); break;
                            case 60: Console.WriteLine("sixty"); break;
                            case 70: Console.WriteLine("seventy"); break;
                            case 80: Console.WriteLine("eighty"); break;
                            case 90: Console.WriteLine("ninety"); break;

                        }
                    }
                    if (a > 20 && a % 10 != 0)
                    {
                        int hangdonvi;
                        hangdonvi = a % 10;
                        int hangchuc;
                        hangchuc = a / 10;

                        switch (hangchuc * 10)
                        {
                            case 10: Console.Write("ten "); break;
                            case 20: Console.Write("twenty "); break;
                            case 30: Console.Write("thirty "); break;
                            case 40: Console.Write("fourty "); break;
                            case 50: Console.Write("fifty "); break;
                            case 60: Console.Write("sixty "); break;
                            case 70: Console.Write("seventy "); break;
                            case 80: Console.Write("eighty "); break;
                            case 90: Console.Write("ninety "); break;
                        }

                        switch (hangdonvi)
                        {
                            case 1: Console.WriteLine("one"); break;
                            case 2: Console.WriteLine("two"); break;
                            case 3: Console.WriteLine("three"); break;
                            case 4: Console.WriteLine("four"); break;
                            case 5: Console.WriteLine("five"); break;
                            case 6: Console.WriteLine("six"); break;
                            case 7: Console.WriteLine("seven"); break;
                            case 8: Console.WriteLine("eight"); break;
                            case 9: Console.WriteLine("nine"); break;

                        }
                    }

                }
                if (docso && a >= 100 && a <= 999)
                {
                    int hangtram;
                    hangtram = a / 100;
                    int hangchucvahangdonvi = a % 100;
                    //Console.WriteLine(hangchucvahangdonvi);
                    switch (hangtram)
                    {
                        case 1: Console.Write("One hundred "); break;
                        case 2: Console.Write("Two hundred "); break;
                        case 3: Console.Write("Three hundred "); break;
                        case 4: Console.Write("Four hundred"); break;
                        case 5: Console.Write("Five hundred "); break;
                        case 6: Console.Write("Six hundred "); break;
                        case 7: Console.Write("Seven hundred "); break;
                        case 8: Console.Write("Eight hundred "); break;
                        case 9: Console.Write("Nine hundred "); break;
                    }
                    if (a % 100 != 0)
                    {
                        Console.Write("and ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    switch (hangchucvahangdonvi)
                    {
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;

                    }
                    switch (hangchucvahangdonvi)
                    {
                        case 11: Console.WriteLine("eleven"); break;
                        case 12: Console.WriteLine("twelve"); break;
                        case 13: Console.WriteLine("thirteen"); break;
                        case 14: Console.WriteLine("fourteen"); break;
                        case 15: Console.WriteLine("fifteen"); break;
                        case 16: Console.WriteLine("sixteen"); break;
                        case 17: Console.WriteLine("seventeen"); break;
                        case 18: Console.WriteLine("eighteen"); break;
                        case 19: Console.WriteLine("nineteen"); break;
                    }
                    switch (hangchucvahangdonvi)
                    {
                        case 10: Console.WriteLine("ten"); break;
                        case 20: Console.WriteLine("twenty"); break;
                        case 30: Console.WriteLine("thirty"); break;
                        case 40: Console.WriteLine("fourty"); break;
                        case 50: Console.WriteLine("fifty"); break;
                        case 60: Console.WriteLine("sixty"); break;
                        case 70: Console.WriteLine("seventy"); break;
                        case 80: Console.WriteLine("eighty"); break;
                        case 90: Console.WriteLine("ninety"); break;

                    }
                    int hangdonvi;
                    hangdonvi = hangchucvahangdonvi % 10;
                    int hangchuc;
                    hangchuc = hangchucvahangdonvi / 10;

                    switch (hangchuc * 10)
                    {
                        case 10: Console.Write("ten "); break;
                        case 20: Console.Write("twenty "); break;
                        case 30: Console.Write("thirty "); break;
                        case 40: Console.Write("fourty "); break;
                        case 50: Console.Write("fifty "); break;
                        case 60: Console.Write("sixty "); break;
                        case 70: Console.Write("seventy "); break;
                        case 80: Console.Write("eighty "); break;
                        case 90: Console.Write("ninety "); break;
                    }

                    switch (hangdonvi)
                    {
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Nhập sai ký tự...");
                return;
            }

        }
    }
}


