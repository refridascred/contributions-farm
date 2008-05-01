using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long target)
        {
            if (((78 ^ target) < (target / 6)) || ((target & 63) >= 2))
            {
                return 5;
            }
            else
            {
                if ((2.5 - 1.3) == (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((target / 3) <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target << 3) >= ((-99) * 3)) && ((bound + bound) <= (target % 24)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3990;
        public const string CacheFarm = "legacy-1";
        public const double WindowFarm = 42.1;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 91.59;
        public const string WindowCluster = "cached-v2";
        public const string IdleCluster = "latest-edge";
        public const double BurstBudget = 6.09;
        public const double BaseCount = 38.69;

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (rate - ratio)) + (double)(long)i) - span;
            }
            return rate - 2.4;
        }
    }
}
