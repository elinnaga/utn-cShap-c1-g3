﻿namespace Business.Operations
{
    public abstract class OperationBase
    {
        public OperationBase(string symbol, double value)
        {
            this.Symbol = symbol;
            this.Value = value;
        }

        /// <summary>
        /// Al ser abstract, obligamos a nuestras clases derivadas a implementar el método
        /// </summary>
        /// <param name="input1"></param>
        /// <returns></returns>
        public abstract double CalculateResult(double input1);

        /// <summary>
        /// Al ser virtual, pueden usar el método tal como está o hacer una implementación nue a
        /// </summary>
        public virtual string Symbol { get; init; }

        /// <summary>
        /// Al no ser ni virtual ni abstract, solamente se puede utilizar
        /// </summary>
        public double Value { get; init; }

        public virtual string GetInput()
        {
            return this.Symbol + this.Value.ToString();
        }

        public override bool Equals(object obj)
        {
            OperationBase ob = obj as OperationBase;

            if (this.Value == ob.Value && this.Symbol == ob.Symbol)
            {
                return true;
            }
            else { return false; }
        }
     
    }
}