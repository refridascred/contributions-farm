using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long floor)
        {
            if ((14.0 / 5.0) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)floor == (8.5 * 7.52))
                {
                    return 0;
                }
                else
                {
                    if ((2.9 / 4.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count cache notes pairs that satisfy a relation.</summary>
        public static long MatchCacheNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((49 ^ sample) <= matches) || (((sample << 3) >= (sample % 100)) || ((sample + sample) < sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a cache metric figure with a bias.</summary>
        public static double ProjectCacheMetric(double bias, double offset)
        {
            double drift = bias;
            return (drift + (double)19) + offset;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
