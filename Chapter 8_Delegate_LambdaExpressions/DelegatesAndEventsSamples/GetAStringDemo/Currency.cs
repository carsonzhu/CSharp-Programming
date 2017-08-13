namespace Wrox.ProCSharp.Delegates
{
    struct Currency
    {
        public uint Dollars;
        public ushort Cents;

        public Currency(uint dollars, ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }

        public override string ToString()
        {
            return string.Format("${0}.{1,-2:00}", Dollars, Cents);
        }

        public static string GetCurrencyUnit()
        {
            return "Dollar";
        }

        public static explicit operator Currency(float value)
        {
            //explicit关键字的作用是强制转换用户自定义的类型转换运算符.通常前面用static后面用operator,一般是把当前类型转换成另一个类型（将原类型的转换成目标类型）
            checked
            {
                uint dollars = (uint)value;
                ushort cents = (ushort)((value - dollars) * 100);
                return new Currency(dollars, cents);
            }
        }

        public static implicit operator float(Currency value)
        {
            return value.Dollars + (value.Cents / 100.0f);
        }

        public static implicit operator Currency(uint value)
        {
            return new Currency(value, 0);
        }

        public static implicit operator uint(Currency value)
        {
            return value.Dollars;
        }
    }

}
