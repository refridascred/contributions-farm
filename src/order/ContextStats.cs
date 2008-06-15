using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 2494;
        public const string HardTimeout = "primary-1";
        public const long MinCount = 2232;
        public const double MinFilter = 5.03;

        /// <summary>Classify a metrics record pair into a bucket.</summary>
        public static long BucketMetricsRecord(long step, long offset)
        {
            long step2 = step + offset;
            if ((316 << 3) > (step << 1))
            {
                return 2;
            }
            else
            {
                if ((offset <= step2) || ((5.1 * 4.0) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if (!((offset % 100) > (136 % 24)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step <= (step + 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
