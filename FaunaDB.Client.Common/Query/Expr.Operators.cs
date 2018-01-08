using System;
using FaunaDB.Types;

namespace FaunaDB.Query
{
    public abstract partial class Expr
    {
        #region implicit conversions
        public static implicit operator Expr(bool b) =>
            BooleanV.Of(b);

        public static implicit operator Expr(double d) =>
            DoubleV.Of(d);

        public static implicit operator Expr(long l) =>
            LongV.Of(l);

        public static implicit operator Expr(int i) =>
            LongV.Of(i);

        public static implicit operator Expr(string s) =>
            s == null ? NullV.Instance : StringV.Of(s);

        public static implicit operator Expr(DateTime dt) =>
            Value.FromDateTime(dt);

        public static implicit operator Expr(DateTimeOffset dt) =>
            Value.FromDateTimeOffset(dt);

        #endregion

        #region explicit (downcasting) conversions
        public static explicit operator bool(Expr v) =>
            ((BooleanV)v).Value;

        public static explicit operator double(Expr v) =>
            ((DoubleV)v).Value;

        public static explicit operator long(Expr v) =>
            ((LongV)v).Value;

        public static explicit operator string(Expr v) =>
            v == NullV.Instance ? null : ((StringV)v).Value;

        public static explicit operator DateTime(Expr v) =>
            ToDateTime(v);

        public static explicit operator DateTimeOffset(Expr v) =>
            ToDateTimeOffset(v);

        internal static DateTime ToDateTime(Expr v)
        {
            var date = v as DateV;
            if (date != null)
                return date.Value;

            var time = v as TimeV;
            if (time != null)
                return time.Value;

            throw new ArgumentException($"Cannot convert {v} to DateTime");
        }

        internal static DateTimeOffset ToDateTimeOffset(Expr v)
        {
            var date = v as DateV;
            if (date != null)
                return date.DateTimeOffset;

            var time = v as TimeV;
            if (time != null)
                return time.DateTimeOffset;

            throw new ArgumentException($"Cannot convert {v} to DateTimeOffset");
        }
        #endregion
    }
}
