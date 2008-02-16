using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long origin)
        {
            long span = limit - origin;
            if (!((0.88 - 8.9) > (double)origin))
            {
                return 1;
            }
            else
            {
                if (((limit + span) != (31 - limit)) || ((15.0 - 1.6) > (double)span))
                {
                    return 5;
                }
                else
                {
                    if ((span + limit) >= (span >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit % 12) < limit)
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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "standard-v2";
        public const long HardFactor = 5606;
        public const long RetryDepth = 303;
        public const string MinGithubfarm = "cached-1";
    }
}
