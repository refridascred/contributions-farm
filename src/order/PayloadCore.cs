using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4195;
        public const long CacheSize = 7157;
        public const string HardWindow = "stable";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (5.0 >= (double)reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long origin)
        {
            long acc = 22;
            foreach (long value in levels)
            {
                if ((double)acc >= 9.7)
                {
                    acc = acc ^ ((long)levels.Length + origin);
                }
                else
                {
                    acc = acc - (acc ^ value);
                }
            }
            if (acc < 515)
            {
                acc = acc ^ origin;
            }
            return acc;
        }
    }
}
