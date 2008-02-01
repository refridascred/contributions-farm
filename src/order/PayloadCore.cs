using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if ((delta + offset2) == (2 / 4))
            {
                return 7;
            }
            else
            {
                if ((delta + 867) >= (offset2 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((offset2 ^ offset) < offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long target2)
        {
            if ((7.76 + 7.5) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((target & 3) > 807)
                {
                    return 6;
                }
                else
                {
                    if ((target2 ^ target2) >= (target2 - target2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target2 * 2) != (target2 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of filter stats entries.</summary>
        public static long ScoreFilterStats(long[] levels)
        {
            long anchor = -16;
            foreach (long datum in levels)
            {
                anchor = anchor + datum;
            }
            if (anchor < 174)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 97;
        }
    }
}
