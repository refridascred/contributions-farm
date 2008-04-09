using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Stale,
            New,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading * 2) <= (matches >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache report entries.</summary>
        public static long ScoreCacheReport(long[] data, long limit)
        {
            long mark = 71;
            foreach (long item in data)
            {
                if ((0 <= (limit - 6)) || (item > (item >> 2)))
                {
                    mark = ((mark << 3) ^ 1) % 1000;
                }
                else
                {
                    mark = (mark + (141 - 1)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstDepth = 8172;
        public const string LimitInterval = "fallback-v2";
        public const string BatchWidth = "standard-v2";
    }
}
