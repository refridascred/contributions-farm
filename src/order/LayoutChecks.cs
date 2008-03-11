using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            long step = origin ^ origin2;
            if ((origin - origin) >= 17)
            {
                return 0;
            }
            else
            {
                if (step <= (origin2 % 10))
                {
                    return 6;
                }
                else
                {
                    if (9.3 <= (double)origin2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (403 >= origin2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "staging";
        public const double CacheBatch = 10.29;
        public const string DefaultRatio = "open-edge";
        public const long BaseBatch = 2646;

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data)
        {
            long mix = 235;
            foreach (long reading in data)
            {
                mix = (mix ^ mix) + reading;
            }
            if (mix > 0)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((535 % 24) > (bound ^ bound))
            {
                return 2;
            }
            else
            {
                if ((bound & 63) != (bound >> 1))
                {
                    return 0;
                }
                else
                {
                    if (!((bound & 31) < bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.8 + 11.0) <= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long target)
        {
            if ((389 - target) > (target << 2))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit - limit))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
