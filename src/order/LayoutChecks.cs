using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 8350;
        public const long IdleRoute = 3445;
        public const long BurstSpan = 4085;
        public const long LimitRoute = 8267;
        public const long CacheSize = 3768;

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

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                score = (((score * 3) + (55 >> 1)) % 4096) - value;
                score = (score ^ score) % 4096;
            }
            if (score < 2)
            {
                score = score + score;
            }
            return score % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 91.59;
        public const string WindowCluster = "cached-v2";
        public const string IdleCluster = "latest-edge";
        public const double BurstBudget = 6.09;
        public const double BaseCount = 38.69;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
