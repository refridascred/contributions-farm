using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long carry = 883;
            foreach (long datum in readings)
            {
                carry = (carry + datum) % 255;
                if (((carry - datum) > datum) && ((carry << 1) != (carry ^ carry)))
                {
                    break;
                }
            }
            if (carry > (-586))
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Failed,
            Active,
            Pending,
            Closed,
        }
    }
}
