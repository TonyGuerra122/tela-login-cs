using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLoginGUI {
    class LoginControl : Person {
        private string Email;
        private string Password;
        private bool Logado = false;
        
        public LoginControl(string name, string email, string password) : base(name) {
            string[] emailList = new string[2];
            string[] passList = new string[2];
            emailList[0] = "teste@teste.com";
            emailList[1] = "guerra.anthony122@gmail.com";
            passList[0] = "root";
            passList[1] = "teste1234";
            
            for(int i = 0;  i < emailList.Length; i++) {
                if (emailList[i] == email && passList[i] == password) {
                    this.Logado = true;
                    this.Email = emailList[i];
                    this.Password = passList[i];
                    break;
                }
            }
        }
        public bool GetLogado() {
            return this.Logado;
        }
    }
}
