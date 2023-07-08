using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorConvert
    {
    public static string RecoirHexColor(Color _col, bool _est_0_1)
        {
        string res = "";
        int mult = 1;

        if (_est_0_1)
            {
            mult = 255;
            }

        var temp = RecoirNombresCanalColor(_col.r * mult);
        res += RecoirStrAInt(temp.Item1) + "" + RecoirStrAInt(temp.Item2);

        temp = RecoirNombresCanalColor(_col.g * mult);
        res += RecoirStrAInt(temp.Item1) + "" + RecoirStrAInt(temp.Item2);

        temp = RecoirNombresCanalColor(_col.b * mult);
        res += RecoirStrAInt(temp.Item1) + "" + RecoirStrAInt(temp.Item2);

        return res;
        }

    public static string ColorizerText(string _str, Color _col)
        {
        string res = "<color=#" + RecoirHexColor(_col, true) + ">" + _str + "</color>";
        return res;
        }

    static private (int, int) RecoirNombresCanalColor(float _vale)
        {         
        int a = (int)(_vale / (float)16);
        int b = (int)(_vale) - a * 16;
        return (a, b);            
        }

    static private string RecoirStrAInt(int _a)
        {
        if (_a < 0 || _a > 15)
            {
            throw new System.Exception("Число " + _a + " за пределами ");
            }

        string res = "";

        if (_a < 10)
            {
            res = _a.ToString();
            }

        else
            {
            switch (_a)
                {
                case 10: res = "A"; break;
                case 11: res = "B"; break;
                case 12: res = "C"; break;
                case 13: res = "D"; break;
                case 14: res = "E"; break;
                case 15: res = "F"; break;
                default: break;
                }
            }

        return res;
        }
    }
