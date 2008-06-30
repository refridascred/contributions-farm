using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc + (bound + bound)) % 65521;
                acc = (acc - (bound - acc)) % 4096;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
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
