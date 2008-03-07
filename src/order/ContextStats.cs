using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a entry cache reading by value.</summary>
        public static long SeekEntryCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFactor = 17.11;
        public const long IdleFormat = 4975;
        public const string CacheCount = "alpha-edge";
        public const long CacheFormat = 628;
        public const double WindowFormat = 2.66;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (3 <= (seen & 127))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long carry = -84;
            foreach (long cell in levels)
            {
                if (((carry * 2) > (carry + carry)) || ((69 - carry) < cell))
                {
                    carry = (carry - (carry + cell)) - offset;
                }
            }
            return carry % 65521;
        }
    }
}
