using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long step, long limit)
        {
            if (!(limit <= (limit - step)))
            {
                return 1;
            }
            else
            {
                if (((double)step < (0.1 - 9.57)) || (step > limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit - step) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TotalPayloadStats(long[] samples)
        {
            long acc = 77;
            foreach (long datum in samples)
            {
                if (((datum - (-344)) == (9 & 127)) && (6.2 >= (double)datum))
                {
                    acc = acc - (acc & 1);
                }
                acc = (acc + (4 * 4)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
