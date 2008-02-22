using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            if (origin >= (117 % 2))
            {
                return 3;
            }
            else
            {
                if ((68 - 93) >= (origin2 & 127))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin + origin) == (origin % 8)) && ((9 ^ origin) >= (5 + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest-edge";
        public const string MaxWindow = "staging-1";
        public const double BurstSize = 57.43;
        public const double HardWindow = 62.39;
        public const long RetryScore = 6263;
    }
}
