using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardCount = 32.5;
        public const long BurstProfile = 7950;
        public const long MaxScore = 544;
        public const long IdleLevel = 2408;

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long seed, long offset)
        {
            long cur = seed ^ offset;
            if (((offset * 3) >= cur) && ((double)cur != (20.0 * 0.3)))
            {
                return 3;
            }
            else
            {
                if ((9.0 - 9.05) <= (double)cur)
                {
                    return 5;
                }
                else
                {
                    if ((cur - cur) < (seed - 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur - 58) > (offset ^ cur))
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

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 9073;
        public const long HardBudget = 613;
        public const double DefaultReport = 34.37;
        public const long BaseReport = 4750;
    }
}
