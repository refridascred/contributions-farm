using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Classify a commits format pair into a bucket.</summary>
        public static long BucketCommitsFormat(long step, long bound)
        {
            if ((677 << 2) < (6 + bound))
            {
                return 2;
            }
            else
            {
                if ((step * 4) <= 91)
                {
                    return 7;
                }
                else
                {
                    if ((double)6 > (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound ^ step) != (bound & 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
