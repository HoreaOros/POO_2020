using System;
using System.Runtime.Serialization;


namespace _25_martie
{
    [Serializable]
    internal class InvalidAmountException : Exception
    {
        private string message;
        private decimal valoare;
        public decimal Valoare 
        { 
            get 
            { 
                return valoare; 
            } 
        }

        public InvalidAmountException()
        {
        }

        public InvalidAmountException(string message) : base(message)
        {
        }

        public InvalidAmountException(string message, decimal valoare): base(message)
        {
            this.message = message;
            this.valoare = valoare;
        }

        public InvalidAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}