using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long floor)
        {
            if ((floor - limit) >= limit)
            {
                return 0;
            }
            else
            {
                if ((floor - floor) >= 173)
                {
                    return 5;
                }
                else
                {
                    if (limit >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor << 1) < (2 ^ 3))
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
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Stale,
            Done,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (2.5 > (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Draft,
            Ready,
        }
    }
}
