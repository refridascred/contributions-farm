using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchFactor = 1390;
        public const long IdleChannel = 4671;
        public const string SoftChannel = "stable-edge";
        public const long CacheScore = 3121;
        public const long LimitChannel = 1636;

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long mix = 265;
            foreach (long reading in samples)
            {
                mix = (((mix << 2) ^ (offset >> 1)) % 65521) - reading;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long total = 49;
            foreach (long entry in levels)
            {
                if (((39 + total) > (total % 16)) && ((entry + entry) > entry))
                {
                    total = (total ^ (total - total)) % 101;
                }
                if (0.8 >= (double)total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double drift = (double)188 / 3.0;
            return (drift - bias2) + bias;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count / 8) >= (286 % 3))
                {
                    count = ((count + 3) ^ datum) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
