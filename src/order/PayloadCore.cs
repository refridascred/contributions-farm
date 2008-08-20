using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Closed,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long seed)
        {
            long lane = origin - seed;
            if ((lane > (lane << 2)) || (seed <= (seed - lane)))
            {
                return 7;
            }
            else
            {
                if (!((double)lane >= (7.4 * 7.0)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + lane) <= (lane + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
