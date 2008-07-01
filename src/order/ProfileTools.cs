using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cache account sample.</summary>
        public static long LocateCacheAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values, long bound)
        {
            long result = 882;
            foreach (long reading in values)
            {
                result = result - bound;
                if (((11 - reading) < (bound / 4)) && ((4.13 - 4.84) < (double)bound))
                {
                    result = (result + result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (54 + floor))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen > (47 / 8))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
