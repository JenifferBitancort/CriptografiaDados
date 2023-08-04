using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _33___Criptografia_de_dados
{
    class CriptoMD5
    {
        public string RetornaMD5(string Senha)      //Metodo para passar uma senha
        {
            using (MD5 md5Hash = MD5.Create())         
            {
                return RetornarHash(md5Hash, Senha);   
            }
        }
       

        public bool CompararMD5(string senhaEntrada, string senhaMD5) //Metodo com senha do usuário e senha criptografada
        {
            string senha = RetornaMD5(senhaEntrada);   
            if (VerificarHash(senhaMD5, senha))        
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string RetornarHash(MD5 md5Hash, string input)  //Metodo interno que cria a Hash md5, atraves de objeto md5 e string
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();   

            for (int i = 0; i < data.Length; i++) 
            {
                sBuilder.Append(data[i].ToString("X2")); 
            }

            return sBuilder.ToString(); 
        }


        private bool VerificarHash(string input, string hash)   //Metodo interno que compara as duas hash
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;  
            if(comparar.Compare(input, hash) == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
