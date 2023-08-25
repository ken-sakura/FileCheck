// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace ConsoleApplication1
{
    class testApp
    {
        public static void Main()
        {
            Console.Write("input filepath : ");
            var varFilePath = Console.ReadLine();
            if(varFilePath == ""){
                Console.WriteLine("処理を終了します。");
                return;
            }


            var varFileList = Directory.GetFiles(varFilePath, "*",SearchOption.AllDirectories);

            var cntFileList = varFileList.Length;

            if(cntFileList <= 0){
                Console.WriteLine("ファイルが存在しません");
            }else{
                for(int icount = 0 ; icount < cntFileList ; icount++){
                    Console.WriteLine(varFileList[icount]);

                }

            }

            Console.WriteLine("ファイル件数：" + cntFileList);
            Console.WriteLine("処理終了");
            return;


        }
    }
}
