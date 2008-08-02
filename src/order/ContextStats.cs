using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long seed2)
        {
            if ((double)339 < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((seed2 & 63) >= (5 * 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Rank { get; set; }
            public double Token { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a buffer command pair into a bucket.</summary>
        public static long BucketBufferCommand(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((bound - cur) != (cur - bound))
            {
                return 4;
            }
            else
            {
                if ((offset > (offset + bound)) && ((cur % 10) <= (cur - cur)))
                {
                    return 8;
                }
                else
                {
                    if (1 >= (cur - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
