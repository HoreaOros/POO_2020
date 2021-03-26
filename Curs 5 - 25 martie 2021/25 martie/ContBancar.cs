using System;
using System.Text;

namespace _25_martie
{
    internal class ContBancar
    {
        #region data members
        private decimal sold = 0;
        private string titular;
        private Guid id;
        #endregion

        #region ctors
        private ContBancar()
        {
            Console.WriteLine("Am creat un obiect de tip ContBancar");
            id = Guid.NewGuid();
            sold = 0;
        }

        public ContBancar(string titular): this()
        {
            this.titular = titular;
        }

        #endregion

        #region Operations
        public void Depune(decimal valoare)
        {
            if (valoare > 0)
            {
                sold += valoare;
                Logger.log($"Succes: Depus <{valoare}> in cont <{id}>, titular <{titular}> la <{DateTime.Now}>");
            }
            else
            {
                Logger.log($"Fail: Depunere <{valoare}> in cont <{id}>, titular <{titular}> la <{DateTime.Now}>");
                throw new InvalidAmountException("Valoare depusa este negativa", valoare);
            }
                
        }
        public void Retrage(decimal valoare)
        {
            if (valoare <= sold)
            {
                Logger.log($"Succes: Retragere <{valoare}> din cont <{id}>, titular <{titular}> la <{DateTime.Now}>");
                sold -= valoare;
            }
            else
            {
                Logger.log($"Fail: Retragere <{valoare}> din cont <{id}>, titular <{titular}> la <{DateTime.Now}>");
                throw new InvalidAmountException("Valoare retrasa este prea mare", valoare);
            }
                
        }
        #endregion

        #region overrides
        public override string ToString()
        {
            return new StringBuilder()
              .AppendLine($"Cont bancar <ID> - {id}")
              .AppendLine($"\tTitluar - {titular}")
              .AppendLine($"\tSold - {sold}")
              .ToString();
        }
        #endregion
        
    }
}