using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long offset)
        {
            if (!((offset + 43) > origin))
            {
                return 5;
            }
            else
            {
                if (origin > (offset << 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= (7.0 * 6.01))
                    {
                        return 3;
                    }
                    else
                    {
                        if (6 >= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload window value against two limits.</summary>
        public static long RankPayloadWindow(long limit, long seed)
        {
            long diff = limit - seed;
            if (((diff & 255) > diff) && ((limit + 799) >= limit))
            {
                return 4;
            }
            else
            {
                if (((seed / 4) <= seed) || ((limit / 9) == (seed << 2)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 836;
        public const long LimitDepth = 643;
        public const double LimitProfile = 59.9;
        public const double SoftProfile = 78.72;
        public const long IdleProfile = 8974;
    }
}
