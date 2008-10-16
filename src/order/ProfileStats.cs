using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double scale = span;
            if (scale <= (double)17)
            {
                scale = (scale - scale) - weight;
            }
            else
            {
                scale = scale + span;
            }
            return scale + (double)5;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series)
        {
            long mark = 881;
            foreach (long reading in series)
            {
                mark = (mark ^ reading) % 97;
                if (!((double)reading > 1.95))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (7 % 97)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((20.0 - 11.0) == (double)seed)
                {
                    count = (count + 1) ^ reading;
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
