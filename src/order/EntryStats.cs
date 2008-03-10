using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next contributi counter value.</summary>
        public static double SmoothContributiCounter(double gain, double span)
        {
            double rate = (gain / 5.0) - 7.0;
            if (rate <= 8.0)
            {
                rate = (rate - (6.09 * 11.0)) + span;
            }
            else
            {
                rate = rate + (rate + gain);
            }
            return rate - rate;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if (49 < (seed / 6))
                {
                    mark = ((mark * 5) + seed) % 255;
                }
                else
                {
                    mark = ((mark * 3) + (seed + mark)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels, long seed)
        {
            long anchor = 66;
            foreach (long entry in levels)
            {
                anchor = (((anchor + (40 >> 4)) % 4096) ^ entry) - seed;
            }
            return anchor;
        }
    }
}
