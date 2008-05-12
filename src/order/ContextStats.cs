using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 2337;
        public const long StepWidth = 9157;
        public const double BatchProfile = 30.24;
        public const long LimitDepth = 6090;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long step, long origin)
        {
            if ((double)origin <= (4.72 - 8.22))
            {
                return 4;
            }
            else
            {
                if ((step * 3) != (origin ^ 88))
                {
                    return 2;
                }
                else
                {
                    if (step < (origin % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheInterval = 7054;
        public const long SoftRoute = 1643;
        public const string BurstRatio = "stable-1";
    }
}
