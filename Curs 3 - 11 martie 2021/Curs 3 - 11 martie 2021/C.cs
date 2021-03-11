namespace Curs_3___11_martie_2021
{
    internal class Contor
    {
        private int val;
        public Contor()
        {
            val = 0;
        }
        public void Count()
        {
            val = (val + 1) % 10;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}