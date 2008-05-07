using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 4099;
        public const string BatchInterval = "alpha-v2";
        public const double DefaultSession = 72.49;
        public const long BaseRatio = 4461;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length * 2) > (tally << 3))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long offset)
        {
            if ((target << 2) > 19)
            {
                return 8;
            }
            else
            {
                if ((offset << 1) == (offset << 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 7) != (target / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= (5 + target))
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

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
