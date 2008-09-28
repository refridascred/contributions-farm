using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long AuditEntryChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((79 % 3) >= (hits / 2))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Validate account tools readings against a bound.</summary>
        public static bool CheckAccountToolsRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Active,
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long ClassifyChecksPayload(long bound, long bound2)
        {
            if ((bound2 <= (bound + bound)) || (bound > (bound2 - bound2)))
            {
                return 0;
            }
            else
            {
                if ((bound2 ^ bound2) < (bound + bound2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a command order pair into a bucket.</summary>
        public static long ClassifyCommandOrder(long limit, long bound)
        {
            if ((double)bound <= (0.4 * 2.07))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (3.33 * 9.6))
                {
                    return 6;
                }
                else
                {
                    if ((limit + bound) > (bound * 2))
                    {
                        return 2;
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
