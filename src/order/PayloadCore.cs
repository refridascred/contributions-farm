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

        /// <summary>Validate graph tools readings against a bound.</summary>
        public static bool GuardGraphToolsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
