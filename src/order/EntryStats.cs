using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 3) > 118)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long anchor = 79;
            foreach (long datum in values)
            {
                if ((datum + datum) == (anchor + anchor))
                {
                    anchor = (((anchor << 2) ^ 3) % 255) - limit;
                }
                else
                {
                    anchor = (anchor ^ ((-944) + anchor)) % 4096;
                }
            }
            if (anchor > 49)
            {
                anchor = (anchor + (26 % 64)) % 97;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2183;
        public const long LimitFactor = 5020;
        public const long DefaultSize = 9077;
        public const double HardChecks = 30.44;
        public const long DefaultChecks = 8513;
    }
}
