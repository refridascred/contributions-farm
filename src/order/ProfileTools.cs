using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((38 * 5) <= (hits + 248)))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen / 8) <= seen)
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((1.92 / 4.0) == (double)tally) || ((sample - tally) < (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels)
        {
            long result = 984;
            foreach (long item in levels)
            {
                if ((item - item) >= (result << 1))
                {
                    result = result ^ (557 >> 5);
                }
                else
                {
                    result = ((result << 2) ^ item) % 97;
                }
            }
            if (result < 67)
            {
                result = (result * 5) + result;
            }
            return result;
        }
    }
}
