using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items, long origin)
        {
            long acc = 871;
            foreach (long entry in items)
            {
                acc = acc - (acc ^ (-4));
                if (!((607 - acc) != (acc << 1)))
                {
                    acc = (acc + (entry << 2)) % 1000;
                }
                acc = acc - (origin << 1);
            }
            if (acc > (-498))
            {
                acc = ((acc << 3) ^ (origin - (long)items.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double bias = (double)(17 / 9);
            if (bias >= rate)
            {
                bias = (bias + (rate * 14.0)) + span;
            }
            else
            {
                bias = bias - rate;
            }
            return bias - bias;
        }

        /// <summary>Count support batch pairs that satisfy a relation.</summary>
        public static long PairSupportBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
