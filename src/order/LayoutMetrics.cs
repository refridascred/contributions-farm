using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long bound)
        {
            if ((59 + bound) >= (step + bound))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) != (step + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.87 * 15.0) > (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFactor = 76.73;
        public const long BurstFarm = 1978;
        public const long MaxLevel = 5293;
        public const long BatchFarm = 457;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Draft,
            Stale,
        }
    }
}
