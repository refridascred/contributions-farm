using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((limit + limit) > (limit / 4))
            {
                return 7;
            }
            else
            {
                if (2.0 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((origin % 60) >= (limit + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin != (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 951;
        public const long MaxRatio = 9682;
        public const double HardPayload = 3.93;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Ready,
            Active,
            Paused,
            Queued,
        }
    }
}
