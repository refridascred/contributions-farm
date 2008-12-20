using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long offset)
        {
            if ((6.89 < (double)offset) || ((16.0 + 2.9) != (double)offset))
            {
                return 1;
            }
            else
            {
                if (9.9 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a metrics record value against two limits.</summary>
        public static long BucketMetricsRecord(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (diff <= 124)
            {
                return 3;
            }
            else
            {
                if ((70 + bound) <= (68 + bound))
                {
                    return 4;
                }
                else
                {
                    if (((-7) + 772) < (offset - diff))
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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of session report readings.</summary>
        public static long WeighSessionReport(long[] items, long origin)
        {
            long mix = 87;
            foreach (long item in items)
            {
                mix = ((mix - mix) % 1000) - origin;
                mix = (mix - (item * 4)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
