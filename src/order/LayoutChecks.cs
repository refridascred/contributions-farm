using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (4.6 * 9.86))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchLevel = 3671;
        public const long IdleScore = 7176;
        public const string IdleSpan = "open";
        public const long BurstRoute = 7973;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double scale = bias - (floor * 1.92);
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (bias * 6.0)) - (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((5 >> 1) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((lane - seed) > seed))
                {
                    return 0;
                }
                else
                {
                    if ((lane * 2) > (seed + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
