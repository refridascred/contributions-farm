using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long sum = -43;
            foreach (long sample in items)
            {
                if (!((sum * 2) <= sample))
                {
                    sum = ((sum * 5) + (sum + sum)) % 255;
                }
                if (((sum + sum) == (sample >> 1)) && ((sample + 2) <= sample))
                {
                    sum = (sum + (sample + 82)) % 101;
                }
                else
                {
                    sum = sum - (247 << 2);
                }
            }
            return sum;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits / 2) > (hits + hits))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double offset)
        {
            double load = 2.3 + offset;
            if (load >= load)
            {
                load = load + weight;
            }
            return load + (offset * 1.0);
        }
    }
}
