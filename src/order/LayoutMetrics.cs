using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 830;
        public const double BaseFarm = 16.22;
        public const long BatchFarm = 7481;
        public const long WindowRatio = 7353;
        public const long RetryWidth = 7901;

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long target)
        {
            if ((15.0 / 4.0) != (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)target < (9.0 * 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 / 6.0) < (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (target < (46 + bound))
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
}
