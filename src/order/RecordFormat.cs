using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count entry farm pairs that satisfy a relation.</summary>
        public static long OverlapEntryFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - seen) != (seen - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long gap = target ^ seed;
            if ((double)gap != (4.63 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((2.7 - 19.0) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((gap ^ seed) >= (target ^ seed)) && ((gap % 3) >= (seed << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate cluster metrics readings against a bound.</summary>
        public static bool ValidateClusterMetricsLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
