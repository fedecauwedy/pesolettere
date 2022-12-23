using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        int parola=0;
        for(int a=0; a<input.Length; a++)
        {
            switch (input[parola])
            {
            case 'A':
            parola=parola+1;
            break;

            case 'a':
            parola=parola+1;
            break;

            case 'B':
            parola=parola+3;
            break;

            case 'b':
            parola=parola+3;
            break;

            case 'C':
            parola=parola+3;
            break;

            case 'c':
            parola=parola+3;
            break;

            case 'D':
            parola=parola+2;
            break;

            case 'd':
            parola=parola+2;
            break;

            case 'E':
            parola=parola+1;
            break;

            case 'e':
            parola=parola+1;
            break;


            case 'F':
            parola=parola+4;
            break;

            case 'f':
            parola=parola+4;
            break;

            case 'G':
            parola=parola+2;
            break;

            case 'g':
            parola=parola+2;
            break;

            case 'H':
            parola=parola+4;
            break;

            case 'h':
            parola=parola+4;
            break;

            case 'I':
            parola=parola+1;
            break;

            case 'i':
            parola=parola+1;
            break;

            case 'J':
            parola=parola+8;
            break;

            case 'j':
            parola=parola+8;
            break;

            case 'K':
            parola=parola+5;
            break;

            case 'k':
            parola=parola+5;
            break;

            case 'L':
            parola=parola+1;
            break;

            case 'l':
            parola=parola+1;
            break;

            case 'M':
            parola=parola+3;
            break;

            case 'm':
            parola=parola+3;
            break;

            case 'N':
            parola=parola+1;
            break;

            case 'n':
            parola=parola+1;
            break;

            case 'O':
            parola=parola+1;
            break;

            case 'o':
            parola=parola+1;
            break;

            case 'P':
            parola=parola+3;
            break;

            case 'p':
            parola=parola+3;
            break;

            case 'Q':
            parola=parola+10;
            break;

            case 'q':
            parola=parola+10;
            break;

            case 'R':
            parola=parola+1;
            break;

            case 'r':
            parola=parola+1;
            break;

            case 'S':
            parola=parola+1;
            break;

            case 's':
            parola=parola+1;
            break;

            case 'T':
            parola=parola+1;
            break;

            case 't':
            parola=parola+1;
            break;

            case 'U':
            parola=parola+1;
            break;

            case 'u':
            parola=parola+1;
            break;

            case 'V':
            parola=parola+4;
            break;

            case 'v':
            parola=parola+4;
            break;

            case 'W':
            parola=parola+4;
            break;

            case 'w':
            parola=parola+4;
            break;

            case 'X':
            parola=parola+8;
            break;

            case 'x':
            parola=parola+8;
            break;

            case 'Y':
            parola=parola+4;
            break;

            case 'y':
            parola=parola+4;
            break;

            case 'Z':
            parola=parola+10;
            break;

            case 'z':
            parola=parola+10;
            break;
        }
        }
        
        return parola;
    }
}