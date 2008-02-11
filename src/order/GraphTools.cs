using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 9297;
        public const long BurstScore = 7940;
        public const long BurstSpan = 3411;
        public const long DefaultReport = 7309;

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Queued,
            Draft,
            Closed,
            Active,
        }

        /// <summary>Count cluster command pairs that satisfy a relation.</summary>
        public static long OverlapClusterCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long origin2)
        {
            long offset = origin ^ origin2;
            if ((double)origin2 == (double)217)
            {
                return 4;
            }
            else
            {
                if (((origin2 + origin2) >= (offset + 73)) && ((offset + 657) <= (offset % 16)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin2 >= (6.6 + 6.81))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
