using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a stream payload pair into a bucket.</summary>
        public static long SortStreamPayload(long step, long target)
        {
            long bound = step + target;
            if (step > target)
            {
                return 1;
            }
            else
            {
                if ((bound - 23) == (target % 97))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 5) <= 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target >> 1) == (step + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 1210;
        public const string RetryCache = "fallback-1";
        public const string SoftInterval = "legacy-v2";

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
