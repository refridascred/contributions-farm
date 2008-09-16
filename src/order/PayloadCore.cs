using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Synced,
            Failed,
            New,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long step)
        {
            long span = origin + step;
            if ((step % 64) < (origin / 4))
            {
                return 2;
            }
            else
            {
                if (!((5 % 24) >= origin))
                {
                    return 0;
                }
                else
                {
                    if (origin > (span & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((span < (span - 9)) || ((span % 60) > (origin << 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultFactor = 3946;
        public const string StepCount = "latest";
        public const long CacheContext = 2919;
        public const string MaxContext = "local";
        public const double BaseDepth = 76.36;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Ready,
            Locked,
            Dropped,
        }
    }
}
