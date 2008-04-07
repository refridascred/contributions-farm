using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long seed)
        {
            if (seed < (seed >> 4))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 10) != (541 / 2))
                {
                    return 1;
                }
                else
                {
                    if (((seed << 1) <= (step - step)) && ((461 & 63) > (seed << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the payload stream series from a seed.</summary>
        public static long RollPayloadStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i ^ mark)) % 101;
                mark = (mark * 4) + origin;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            New,
            Active,
            Paused,
            Done,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
