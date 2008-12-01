using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long step)
        {
            if ((target / 7) <= 398)
            {
                return 0;
            }
            else
            {
                if (3 >= (step + target))
                {
                    return 4;
                }
                else
                {
                    if ((6.1 - 5.0) > (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - step) <= (target & 255))
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

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum >> 3))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
