using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Active,
            Pending,
        }

        /// <summary>Derive the next record session value from a seed.</summary>
        public static long StepRecordSession(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long step, long bound)
        {
            long gap = step + bound;
            if ((((-74) >> 5) < (gap + 28)) && (((-502) + 727) >= gap))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound > (379 + step)) && (10 <= bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a format graph pair into a bucket.</summary>
        public static long BucketFormatGraph(long limit, long bound)
        {
            if ((7.6 / 4.0) == (double)limit)
            {
                return 0;
            }
            else
            {
                if (((bound % 5) >= bound) && ((bound >> 5) != (bound - limit)))
                {
                    return 8;
                }
                else
                {
                    if ((limit > bound) && ((limit >> 2) != (limit >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
