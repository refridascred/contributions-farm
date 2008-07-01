using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 63.19;
        public const long SoftFactor = 6879;
        public const double CacheSpan = 27.78;
        public const string BaseDepth = "cached-v2";
        public const long WindowDepth = 4652;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 2) + 58;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count contributi profile pairs that satisfy a relation.</summary>
        public static long OverlapContributiProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
