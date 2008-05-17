using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((6.05 / 9.0) == (double)seed)
                {
                    sum = (sum * 5) + 494;
                }
                sum = (sum + ((long)i + 1)) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
