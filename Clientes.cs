namespace Atividade
{
    class Clientes
    {
        //Atributos
        public string nome {get;set;}
        public string endereco {get;set;}
        public float valor {get; protected set;} //protected é o encapsulamento
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}

        //metodos
        public virtual void PagarImposto(float v) //virtual serve para as classes filhas poderem reescrever esse metodo
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;

        }
    }
}