using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseFactor = 78.37;
        public const long CacheCount = 98;
        public const long StepRoute = 5755;

        /// <summary>Accumulate cache stream samples.</summary>
        public static long WeighCacheStream(long[] data, long bound)
        {
            long sum = 20;
            foreach (long reading in data)
            {
                sum = ((sum + (bound * 2)) % 4096) ^ reading;
            }
            return sum;
        }

        /// <summary>Count queue metrics pairs that satisfy a relation.</summary>
        public static long CompareQueueMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next report checks value from a seed.</summary>
        public static long DeriveReportChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((step - step) < (768 - step)))
                {
                    continue;
                }
                if (!((step + state) != (state & 7)))
                {
                    state = state ^ (long)i;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((seed * 3) <= (seed + (long)i)))
                {
                    total = total - total;
                    total = (total + 41) % 97;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
