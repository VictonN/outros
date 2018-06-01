using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CriptografiaFunção
{
    class Program
    {
        static void BemVindo(String nome)
        {
            Console.WriteLine("Ola {0}, seja bem vindo ao programa de criptografia.", nome);
        }

        static void SalvarCript(string TextoCriptografado)
        {
            Console.WriteLine("Digite o nome do arquivo.");
            string txtCP = Console.ReadLine();
            string path = @"c:\temp\" + txtCP + ".txt";
            if (!File.Exists(path))
            {
                // Criando arquivo para gravar.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(TextoCriptografado);
                }
            }
            Console.WriteLine("A sua criptografia foi salva!");
        }

        static void SalvarDescript(string TextoDescriptografado)
        {
            Console.WriteLine("Digite o nome do arquivo.");
            string txtCP = Console.ReadLine();
            string path = @"c:\temp\" + txtCP + ".txt";
            if (!File.Exists(path))
            {
                // Criando arquivo para gravar.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(TextoDescriptografado);
                }
                Console.WriteLine("A sua criptografia foi salva!");
            }
        }

        static void Main(string[] args)
        {
            //Inicio da aplicação, perguntando o que o usuario gostaria de fazer.
            //Existem duas opções, "1" para criptografar e "2" para des-criptografar.
            bool r = true;
            do
            {
                int Lpc;
                int Lpd;
                int digite;

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Digite o seu nome.");
                string nome = Console.ReadLine();
                BemVindo(nome);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Digite:\n1 - Para criptografar. \n2 - Para descriptografar.");
                digite = int.Parse(Console.ReadLine());
                //Quando o usuario digitar "1" irá aparecer a opção de criptografar.
                //Após criptografar, o usuario terá a possibilidade de sal-var o que foi criptografado em um arquivo .txt.
                if (digite == 1)
                {
                    //Receber as informações para que possa seguir o passo.
                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("O que deseja criptografar?");
                    string textoParaCriptografar = Console.ReadLine();

                    String[] criptoAlfabeto = new String[120] { "anotz", "anozt", "antoz", "antzo", "anzot", "anzto", "aontz", "aonzt", "aotnz", "aotzn", "aoznt", "aoztn", "atnoz", "atnzo", "atonz", "atozn", "atzno", "atzon", "aznot", "aznto", "azont", "azotn", "aztno", "azton", "naotz", "naozt", "natoz", "natzo", "nazot", "nazto", "noatz", "noazt", "notaz", "notza", "nozat", "nozta", "ntaoz", "ntazo", "ntoaz", "ntoza", "ntzao", "ntzoa", "nzaot", "nzato", "nzoat", "nzota", "nztao", "nztoa", "oantz", "oanzt", "oatnz", "oatzn", "oaznt", "oaztn", "onatz", "onazt", "ontaz", "ontza", "onzat", "onzta", "otanz", "otazn", "otnaz", "otnza", "otzan", "otzna", "ozant", "ozatn", "oznat", "oznta", "oztan", "oztna", "tanoz", "tanzo", "taonz", "taozn", "tazno", "tazon", "tnaoz", "tnazo", "tnoaz", "tnoza", "tnzao", "tnzoa", "toanz", "toazn", "tonaz", "tonza", "tozan", "tozna", "tzano", "tzaon", "tznao", "tznoa", "tzoan", "tzona", "zanot", "zanto", "zaont", "zaotn", "zatno", "zaton", "znaot", "znato", "znoat", "znota", "zntao", "zntoa", "zoant", "zoatn", "zonat", "zonta", "zotan", "zotna", "ztano", "ztaon", "ztnao", "ztnoa", "ztoan", "ztona" };
                    String TextoCriptografado = String.Empty;
                    //Estrutura de repetição para criptografar.
                    for (int i = 0; i < textoParaCriptografar.Length; i++)
                    {
                        switch (textoParaCriptografar[i])
                        {
                            case 'a':
                                TextoCriptografado += criptoAlfabeto[0];
                                break;
                            case 'b':
                                TextoCriptografado += criptoAlfabeto[1];
                                break;
                            case 'c':
                                TextoCriptografado += criptoAlfabeto[2];
                                break;
                            case 'd':
                                TextoCriptografado += criptoAlfabeto[3];
                                break;
                            case 'e':
                                TextoCriptografado += criptoAlfabeto[4];
                                break;
                            case 'f':
                                TextoCriptografado += criptoAlfabeto[5];
                                break;
                            case 'g':
                                TextoCriptografado += criptoAlfabeto[6];
                                break;
                            case 'h':
                                TextoCriptografado += criptoAlfabeto[7];
                                break;
                            case 'i':
                                TextoCriptografado += criptoAlfabeto[8];
                                break;
                            case 'j':
                                TextoCriptografado += criptoAlfabeto[9];
                                break;
                            case 'k':
                                TextoCriptografado += criptoAlfabeto[10];
                                break;
                            case 'l':
                                TextoCriptografado += criptoAlfabeto[11];
                                break;
                            case 'm':
                                TextoCriptografado += criptoAlfabeto[12];
                                break;
                            case 'n':
                                TextoCriptografado += criptoAlfabeto[13];
                                break;
                            case 'o':
                                TextoCriptografado += criptoAlfabeto[14];
                                break;
                            case 'p':
                                TextoCriptografado += criptoAlfabeto[15];
                                break;
                            case 'q':
                                TextoCriptografado += criptoAlfabeto[16];
                                break;
                            case 'r':
                                TextoCriptografado += criptoAlfabeto[17];
                                break;
                            case 's':
                                TextoCriptografado += criptoAlfabeto[18];
                                break;
                            case 't':
                                TextoCriptografado += criptoAlfabeto[19];
                                break;
                            case 'u':
                                TextoCriptografado += criptoAlfabeto[20];
                                break;
                            case 'v':
                                TextoCriptografado += criptoAlfabeto[21];
                                break;
                            case 'w':
                                TextoCriptografado += criptoAlfabeto[22];
                                break;
                            case 'x':
                                TextoCriptografado += criptoAlfabeto[23];
                                break;
                            case 'y':
                                TextoCriptografado += criptoAlfabeto[24];
                                break;
                            case 'z':
                                TextoCriptografado += criptoAlfabeto[25];
                                break;
                            case 'A':
                                TextoCriptografado += criptoAlfabeto[26];
                                break;
                            case 'B':
                                TextoCriptografado += criptoAlfabeto[27];
                                break;
                            case 'C':
                                TextoCriptografado += criptoAlfabeto[28];
                                break;
                            case 'D':
                                TextoCriptografado += criptoAlfabeto[29];
                                break;
                            case 'E':
                                TextoCriptografado += criptoAlfabeto[30];
                                break;
                            case 'F':
                                TextoCriptografado += criptoAlfabeto[31];
                                break;
                            case 'G':
                                TextoCriptografado += criptoAlfabeto[32];
                                break;
                            case 'H':
                                TextoCriptografado += criptoAlfabeto[33];
                                break;
                            case 'I':
                                TextoCriptografado += criptoAlfabeto[34];
                                break;
                            case 'J':
                                TextoCriptografado += criptoAlfabeto[35];
                                break;
                            case 'K':
                                TextoCriptografado += criptoAlfabeto[36];
                                break;
                            case 'L':
                                TextoCriptografado += criptoAlfabeto[37];
                                break;
                            case 'M':
                                TextoCriptografado += criptoAlfabeto[38];
                                break;
                            case 'N':
                                TextoCriptografado += criptoAlfabeto[39];
                                break;
                            case 'O':
                                TextoCriptografado += criptoAlfabeto[40];
                                break;
                            case 'P':
                                TextoCriptografado += criptoAlfabeto[41];
                                break;
                            case 'Q':
                                TextoCriptografado += criptoAlfabeto[42];
                                break;
                            case 'R':
                                TextoCriptografado += criptoAlfabeto[43];
                                break;
                            case 'S':
                                TextoCriptografado += criptoAlfabeto[44];
                                break;
                            case 'T':
                                TextoCriptografado += criptoAlfabeto[45];
                                break;
                            case 'U':
                                TextoCriptografado += criptoAlfabeto[46];
                                break;
                            case 'V':
                                TextoCriptografado += criptoAlfabeto[47];
                                break;
                            case 'W':
                                TextoCriptografado += criptoAlfabeto[48];
                                break;
                            case 'X':
                                TextoCriptografado += criptoAlfabeto[49];
                                break;
                            case 'Y':
                                TextoCriptografado += criptoAlfabeto[50];
                                break;
                            case 'Z':
                                TextoCriptografado += criptoAlfabeto[51];
                                break;
                            case 'á':
                                TextoCriptografado += criptoAlfabeto[52];
                                break;
                            case 'à':
                                TextoCriptografado += criptoAlfabeto[53];
                                break;
                            case 'é':
                                TextoCriptografado += criptoAlfabeto[54];
                                break;
                            case 'è':
                                TextoCriptografado += criptoAlfabeto[55];
                                break;
                            case 'í':
                                TextoCriptografado += criptoAlfabeto[56];
                                break;
                            case 'ì':
                                TextoCriptografado += criptoAlfabeto[57];
                                break;
                            case 'ó':
                                TextoCriptografado += criptoAlfabeto[58];
                                break;
                            case 'ò':
                                TextoCriptografado += criptoAlfabeto[59];
                                break;
                            case 'ú':
                                TextoCriptografado += criptoAlfabeto[60];
                                break;
                            case 'ù':
                                TextoCriptografado += criptoAlfabeto[61];
                                break;
                            case 'Á':
                                TextoCriptografado += criptoAlfabeto[62];
                                break;
                            case 'À':
                                TextoCriptografado += criptoAlfabeto[63];
                                break;
                            case 'É':
                                TextoCriptografado += criptoAlfabeto[64];
                                break;
                            case 'È':
                                TextoCriptografado += criptoAlfabeto[65];
                                break;
                            case 'Í':
                                TextoCriptografado += criptoAlfabeto[66];
                                break;
                            case 'Ì':
                                TextoCriptografado += criptoAlfabeto[67];
                                break;
                            case 'Ó':
                                TextoCriptografado += criptoAlfabeto[68];
                                break;
                            case 'Ò':
                                TextoCriptografado += criptoAlfabeto[69];
                                break;
                            case 'Ú':
                                TextoCriptografado += criptoAlfabeto[70];
                                break;
                            case 'Ù':
                                TextoCriptografado += criptoAlfabeto[71];
                                break;
                            case '"':
                                TextoCriptografado += criptoAlfabeto[72];
                                break;
                            case '!':
                                TextoCriptografado += criptoAlfabeto[73];
                                break;
                            case '@':
                                TextoCriptografado += criptoAlfabeto[74];
                                break;
                            case '#':
                                TextoCriptografado += criptoAlfabeto[75];
                                break;
                            case '$':
                                TextoCriptografado += criptoAlfabeto[76];
                                break;
                            case '%':
                                TextoCriptografado += criptoAlfabeto[77];
                                break;
                            case '¨':
                                TextoCriptografado += criptoAlfabeto[78];
                                break;
                            case '&':
                                TextoCriptografado += criptoAlfabeto[79];
                                break;
                            case '*':
                                TextoCriptografado += criptoAlfabeto[80];
                                break;
                            case '(':
                                TextoCriptografado += criptoAlfabeto[81];
                                break;
                            case ')':
                                TextoCriptografado += criptoAlfabeto[82];
                                break;
                            case '_':
                                TextoCriptografado += criptoAlfabeto[83];
                                break;
                            case '+':
                                TextoCriptografado += criptoAlfabeto[84];
                                break;
                            case '-':
                                TextoCriptografado += criptoAlfabeto[85];
                                break;
                            case '=':
                                TextoCriptografado += criptoAlfabeto[86];
                                break;
                            case '´':
                                TextoCriptografado += criptoAlfabeto[87];
                                break;
                            case '`':
                                TextoCriptografado += criptoAlfabeto[88];
                                break;
                            case '[':
                                TextoCriptografado += criptoAlfabeto[89];
                                break;
                            case ']':
                                TextoCriptografado += criptoAlfabeto[90];
                                break;
                            case '{':
                                TextoCriptografado += criptoAlfabeto[91];
                                break;
                            case '}':
                                TextoCriptografado += criptoAlfabeto[92];
                                break;
                            case '^':
                                TextoCriptografado += criptoAlfabeto[93];
                                break;
                            case '~':
                                TextoCriptografado += criptoAlfabeto[94];
                                break;
                            case '?':
                                TextoCriptografado += criptoAlfabeto[95];
                                break;
                            case '/':
                                TextoCriptografado += criptoAlfabeto[96];
                                break;
                            case ';':
                                TextoCriptografado += criptoAlfabeto[97];
                                break;
                            case ':':
                                TextoCriptografado += criptoAlfabeto[98];
                                break;
                            case '.':
                                TextoCriptografado += criptoAlfabeto[99];
                                break;
                            case '>':
                                TextoCriptografado += criptoAlfabeto[100];
                                break;
                            case ',':
                                TextoCriptografado += criptoAlfabeto[101];
                                break;
                            case '<':
                                TextoCriptografado += criptoAlfabeto[102];
                                break;
                            case 'ª':
                                TextoCriptografado += criptoAlfabeto[103];
                                break;
                            case 'º':
                                TextoCriptografado += criptoAlfabeto[104];
                                break;
                            case '°':
                                TextoCriptografado += criptoAlfabeto[105];
                                break;
                            case '|':
                                TextoCriptografado += criptoAlfabeto[106];
                                break;
                            case 'ç':
                                TextoCriptografado += criptoAlfabeto[107];
                                break;
                            case 'Ç':
                                TextoCriptografado += criptoAlfabeto[108];
                                break;
                            case '1':
                                TextoCriptografado += criptoAlfabeto[109];
                                break;
                            case '2':
                                TextoCriptografado += criptoAlfabeto[110];
                                break;
                            case '3':
                                TextoCriptografado += criptoAlfabeto[111];
                                break;
                            case '4':
                                TextoCriptografado += criptoAlfabeto[112];
                                break;
                            case '5':
                                TextoCriptografado += criptoAlfabeto[113];
                                break;
                            case '6':
                                TextoCriptografado += criptoAlfabeto[114];
                                break;
                            case '7':
                                TextoCriptografado += criptoAlfabeto[115];
                                break;
                            case '8':
                                TextoCriptografado += criptoAlfabeto[116];
                                break;
                            case '9':
                                TextoCriptografado += criptoAlfabeto[117];
                                break;
                            case '0':
                                TextoCriptografado += criptoAlfabeto[118];
                                break;

                            default:
                                break;
                        }
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("O texto foi criptografado.");
                    Console.WriteLine("O texto criptografado é: {0}", TextoCriptografado);
                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                    //Opção para ver o texto criptografado ou salvar o texto em .txt e ver.

                    Console.WriteLine("Deseja salvar o que foi criptografado em um arquivo texto?");
                    Console.WriteLine("Digite: \n1 - Para SIM. \n0 - Para NÃO.");
                    int Salv = int.Parse(Console.ReadLine());

                    //Receber informação e processar.
                    if (Salv == 1)
                    {
                        SalvarCript(TextoCriptografado);
                    }
                    Console.WriteLine("A sua criptografia foi salva!");
                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                    //Return
                    Console.WriteLine("Deseja realizar mais alguma operação? \nDigite:\n1 - para SIM. \n0 - para NÃO.");
                    Lpc = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    if (Lpc == 1)
                    {
                        r = true;
                    }
                    else
                    {
                        r = false;
                    }


                }
                //Opção "2" descriptografar.
                if (digite == 2)
                {
                    /*
                     Console.WriteLine("Deseja ler algum arquivo salvo
                     */
                    //Receber as informações para que possa seguir o passo.
                    Console.WriteLine("O que deseja Descriptografar?");
                    string textoParaDescriptografar = Console.ReadLine();
                    //Informações para descriptografar.
                    char[] criptoChar = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'á', 'à', 'é', 'è', 'í', 'ì', 'ó', 'ò', 'ú', 'ù', 'Á', 'À', 'É', 'È', 'Í', 'Ì', 'Ó', 'Ò', 'Ú', 'Ù', '"', '!', '@', '#', '$', '%', '¨', '&', '*', '(', ')', '_', '+', '-', '=', '´', '`', '[', ']', '{', '}', '^', '~', '?', '/', ';', ':', '.', '>', ',', '<', 'ª', 'º', '°', '|', 'ç', 'Ç', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; // "ztona"
                    string TextoDescriptografado = string.Empty;

                    for (int i = 0; i < textoParaDescriptografar.Length; i = i+5)
                    {
                        switch (textoParaDescriptografar.Substring(i,5))
                        {

                            case "anotz":
                                TextoDescriptografado += criptoChar[0];
                                break;
                            case "anozt":
                                TextoDescriptografado += criptoChar[1];
                                break;
                            case "antoz":
                                TextoDescriptografado += criptoChar[2];
                                break;
                            case "antzo":
                                TextoDescriptografado += criptoChar[3];
                                break;
                            case "anzot":
                                TextoDescriptografado += criptoChar[4];
                                break;
                            case "anzto":
                                TextoDescriptografado += criptoChar[5];
                                break;
                            case "aontz":
                                TextoDescriptografado += criptoChar[6];
                                break;
                            case "aonzt":
                                TextoDescriptografado += criptoChar[7];
                                break;
                            case "aotnz":
                                TextoDescriptografado += criptoChar[8];
                                break;
                            case "aotzn":
                                TextoDescriptografado += criptoChar[9];
                                break;
                            case "aoznt":
                                TextoDescriptografado += criptoChar[10];
                                break;
                            case "aoztn":
                                TextoDescriptografado += criptoChar[11];
                                break;
                            case "atnoz":
                                TextoDescriptografado += criptoChar[12];
                                break;
                            case "atnzo":
                                TextoDescriptografado += criptoChar[13];
                                break;
                            case "atonz":
                                TextoDescriptografado += criptoChar[14];
                                break;
                            case "atozn":
                                TextoDescriptografado += criptoChar[15];
                                break;
                            case "atzno":
                                TextoDescriptografado += criptoChar[16];
                                break;
                            case "atzon":
                                TextoDescriptografado += criptoChar[17];
                                break;
                            case "aznot":
                                TextoDescriptografado += criptoChar[18];
                                break;
                            case "aznto":
                                TextoDescriptografado += criptoChar[19];
                                break;
                            case "azont":
                                TextoDescriptografado += criptoChar[20];
                                break;
                            case "azotn":
                                TextoDescriptografado += criptoChar[21];
                                break;
                            case "aztno":
                                TextoDescriptografado += criptoChar[22];
                                break;
                            case "azton":
                                TextoDescriptografado += criptoChar[23];
                                break;
                            case "naotz":
                                TextoDescriptografado += criptoChar[24];
                                break;
                            case "naozt":
                                TextoDescriptografado += criptoChar[25];
                                break;
                            case "natoz":
                                TextoDescriptografado += criptoChar[26];
                                break;
                            case "natzo":
                                TextoDescriptografado += criptoChar[27];
                                break;
                            case "nazot":
                                TextoDescriptografado += criptoChar[28];
                                break;
                            case "nazto":
                                TextoDescriptografado += criptoChar[29];
                                break;
                            case "noatz":
                                TextoDescriptografado += criptoChar[30];
                                break;
                            case "noazt":
                                TextoDescriptografado += criptoChar[31];
                                break;
                            case "notaz":
                                TextoDescriptografado += criptoChar[32];
                                break;
                            case "notza":
                                TextoDescriptografado += criptoChar[33];
                                break;
                            case "nozat":
                                TextoDescriptografado += criptoChar[34];
                                break;
                            case "nozta":
                                TextoDescriptografado += criptoChar[35];
                                break;
                            case "ntaoz":
                                TextoDescriptografado += criptoChar[36];
                                break;
                            case "ntazo":
                                TextoDescriptografado += criptoChar[37];
                                break;
                            case "ntoaz":
                                TextoDescriptografado += criptoChar[38];
                                break;
                            case "ntoza":
                                TextoDescriptografado += criptoChar[39];
                                break;
                            case "ntzao":
                                TextoDescriptografado += criptoChar[40];
                                break;
                            case "ntzoa":
                                TextoDescriptografado += criptoChar[41];
                                break;
                            case "nzaot":
                                TextoDescriptografado += criptoChar[42];
                                break;
                            case "nzato":
                                TextoDescriptografado += criptoChar[43];
                                break;
                            case "nzoat":
                                TextoDescriptografado += criptoChar[44];
                                break;
                            case "nzota":
                                TextoDescriptografado += criptoChar[45];
                                break;
                            case "nztao":
                                TextoDescriptografado += criptoChar[46];
                                break;
                            case "nztoa":
                                TextoDescriptografado += criptoChar[47];
                                break;
                            case "oantz":
                                TextoDescriptografado += criptoChar[48];
                                break;
                            case "oanzt":
                                TextoDescriptografado += criptoChar[49];
                                break;
                            case "oatnz":
                                TextoDescriptografado += criptoChar[50];
                                break;
                            case "oatzn":
                                TextoDescriptografado += criptoChar[51];
                                break;
                            case "oaznt":
                                TextoDescriptografado += criptoChar[52];
                                break;
                            case "oaztn":
                                TextoDescriptografado += criptoChar[53];
                                break;
                            case "onatz":
                                TextoDescriptografado += criptoChar[54];
                                break;
                            case "onazt":
                                TextoDescriptografado += criptoChar[55];
                                break;
                            case "ontaz":
                                TextoDescriptografado += criptoChar[56];
                                break;
                            case "ontza":
                                TextoDescriptografado += criptoChar[57];
                                break;
                            case "onzat":
                                TextoDescriptografado += criptoChar[58];
                                break;
                            case "onzta":
                                TextoDescriptografado += criptoChar[59];
                                break;
                            case "otanz":
                                TextoDescriptografado += criptoChar[60];
                                break;
                            case "otazn":
                                TextoDescriptografado += criptoChar[61];
                                break;
                            case "otnaz":
                                TextoDescriptografado += criptoChar[62];
                                break;
                            case "otnza":
                                TextoDescriptografado += criptoChar[63];
                                break;
                            case "otzan":
                                TextoDescriptografado += criptoChar[64];
                                break;
                            case "otzna":
                                TextoDescriptografado += criptoChar[65];
                                break;
                            case "ozant":
                                TextoDescriptografado += criptoChar[66];
                                break;
                            case "ozatn":
                                TextoDescriptografado += criptoChar[67];
                                break;
                            case "oznat":
                                TextoDescriptografado += criptoChar[68];
                                break;
                            case "oznta":
                                TextoDescriptografado += criptoChar[69];
                                break;
                            case "oztan":
                                TextoDescriptografado += criptoChar[70];
                                break;
                            case "oztna":
                                TextoDescriptografado += criptoChar[71];
                                break;
                            case "tanoz":
                                TextoDescriptografado += criptoChar[72];
                                break;
                            case "tanzo":
                                TextoDescriptografado += criptoChar[73];
                                break;
                            case "taonz":
                                TextoDescriptografado += criptoChar[74];
                                break;
                            case "taozn":
                                TextoDescriptografado += criptoChar[75];
                                break;
                            case "tazno":
                                TextoDescriptografado += criptoChar[76];
                                break;
                            case "tazon":
                                TextoDescriptografado += criptoChar[77];
                                break;
                            case "tnaoz":
                                TextoDescriptografado += criptoChar[78];
                                break;
                            case "tnazo":
                                TextoDescriptografado += criptoChar[79];
                                break;
                            case "tnoaz":
                                TextoDescriptografado += criptoChar[80];
                                break;
                            case "tnoza":
                                TextoDescriptografado += criptoChar[81];
                                break;
                            case "tnzao":
                                TextoDescriptografado += criptoChar[82];
                                break;
                            case "tnzoa":
                                TextoDescriptografado += criptoChar[83];
                                break;
                            case "toanz":
                                TextoDescriptografado += criptoChar[84];
                                break;
                            case "toazn":
                                TextoDescriptografado += criptoChar[85];
                                break;
                            case "tonaz":
                                TextoDescriptografado += criptoChar[86];
                                break;
                            case "tonza":
                                TextoDescriptografado += criptoChar[87];
                                break;
                            case "tozan":
                                TextoDescriptografado += criptoChar[88];
                                break;
                            case "tozna":
                                TextoDescriptografado += criptoChar[89];
                                break;
                            case "tzano":
                                TextoDescriptografado += criptoChar[90];
                                break;
                            case "tzaon":
                                TextoDescriptografado += criptoChar[91];
                                break;
                            case "tznao":
                                TextoDescriptografado += criptoChar[92];
                                break;
                            case "tznoa":
                                TextoDescriptografado += criptoChar[93];
                                break;
                            case "tzoan":
                                TextoDescriptografado += criptoChar[94];
                                break;
                            case "tzona":
                                TextoDescriptografado += criptoChar[95];
                                break;
                            case "zanot":
                                TextoDescriptografado += criptoChar[96];
                                break;
                            case "zanto":
                                TextoDescriptografado += criptoChar[97];
                                break;
                            case "zaont":
                                TextoDescriptografado += criptoChar[98];
                                break;
                            case "zaotn":
                                TextoDescriptografado += criptoChar[99];
                                break;
                            case "zatno":
                                TextoDescriptografado += criptoChar[100];
                                break;
                            case "zaton":
                                TextoDescriptografado += criptoChar[101];
                                break;
                            case "znaot":
                                TextoDescriptografado += criptoChar[102];
                                break;
                            case "znato":
                                TextoDescriptografado += criptoChar[103];
                                break;
                            case "znoat":
                                TextoDescriptografado += criptoChar[104];
                                break;
                            case "znota":
                                TextoDescriptografado += criptoChar[105];
                                break;
                            case "zntao":
                                TextoDescriptografado += criptoChar[106];
                                break;
                            case "zntoa":
                                TextoDescriptografado += criptoChar[107];
                                break;
                            case "zoant":
                                TextoDescriptografado += criptoChar[108];
                                break;
                            case "zoatn":
                                TextoDescriptografado += criptoChar[109];
                                break;
                            case "zonat":
                                TextoDescriptografado += criptoChar[110];
                                break;
                            case "zonta":
                                TextoDescriptografado += criptoChar[111];
                                break;
                            case "zotan":
                                TextoDescriptografado += criptoChar[112];
                                break;
                            case "zotna":
                                TextoDescriptografado += criptoChar[113];
                                break;
                            case "ztano":
                                TextoDescriptografado += criptoChar[114];
                                break;
                            case "ztaon":
                                TextoDescriptografado += criptoChar[115];
                                break;
                            case "ztnao":
                                TextoDescriptografado += criptoChar[116];
                                break;
                            case "ztnoa":
                                TextoDescriptografado += criptoChar[117];
                                break;
                            case "ztoan":
                                TextoDescriptografado += criptoChar[118];
                                break;
                            default:
                                break;
                        }
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("O texto foi descriptografado.");
                    Console.WriteLine("O texto descriptografado é: {0}", TextoDescriptografado);
                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                    //Opção para ver o texto criptografado ou salvar o texto em .txt e ver.  

                    Console.WriteLine("Deseja salvar o que foi descriptografado em um arquivo texto?");
                    Console.WriteLine("Digite: \n1 - Para SIM. \n0 - Para NÃO.");
                    int Salv = int.Parse(Console.ReadLine());

                    //Receber informação e processar.
                    if (Salv == 1)
                    {
                        SalvarDescript(TextoDescriptografado);
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

                    //Return
                    Console.WriteLine("Deseja realizar mais alguma operação? \nDigite: \n1 - Para SIM. \n2 - Para NÃO.");
                    Lpd = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("\n");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    if (Lpd == 1)
                    {
                        r = true;
                    }
                    else
                    {
                        r = false;
                    }


                    //Caso não digite nem uma das opções.
                }
                /*else
                {
                    //Console.WriteLine("Obrigado, volte logo!");
                }*/

            } while (r == true);
            Console.WriteLine("Obrigado, volte logo!");

            Console.ReadKey();
        }
    }
}
