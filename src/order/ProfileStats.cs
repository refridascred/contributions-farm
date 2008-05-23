using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Classify a notes counter pair into a bucket.</summary>
        public static long ClassifyNotesCounter(long floor, long bound)
        {
            long gap = floor ^ bound;
            if ((double)floor > 4.7)
            {
                return 0;
            }
            else
            {
                if (((-320) & 255) == (floor >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((gap ^ gap) >= (floor % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap > (gap >> 2)) && (floor >= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool VerifySupportCacheLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
