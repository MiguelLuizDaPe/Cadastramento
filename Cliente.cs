using System;

namespace Cadastramento{
    class Cliente{
        //tudo public pq não tem motivo pra ser private
        public int id;
        public string nome;
        public string endereco;
        public string telefone;
        public string email;

        public Cliente(){}
        public Cliente(int id, string nome, string endereco, string telefone, string email){
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        
    }

}