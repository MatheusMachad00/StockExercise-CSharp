using System;
using System.Globalization;

namespace StockExercise {
    internal class Product {

        public string Name;
        public double Price;
        public int Qtd;

        public override string ToString() {
            return Name
                + ", $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qtd + " unidades, total $ "
                + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double TotalValueInStock() {
            return Qtd * Price;
        }

        public void AddToStock(int value) {
            Qtd += value;
        }

        public void RemoveFromStock(int value) {
            Qtd -= value;
        }

    }
}
