using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (weight / 5.0))
            {
                weight2 = weight2 + (3.7 - weight2);
            }
            else
            {
                weight2 = weight2 - (double)42;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + span;
        }

        /// <summary>Iterate the batch order series from a seed.</summary>
        public static long StepBatchOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = carry ^ carry;
                    carry = (carry - (seed + (long)i2)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((57 & 127) > value)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
