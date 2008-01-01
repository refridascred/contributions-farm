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

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long limit)
        {
            long anchor = 7;
            foreach (long datum in items)
            {
                if (((double)83 > (double)(long)items.Length) || ((limit + anchor) >= anchor))
                {
                    anchor = ((anchor * 2) + (513 + datum)) % 1000;
                }
                else
                {
                    anchor = (anchor + (limit - 4)) % 1000;
                }
            }
            if (anchor > (-5))
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 4096;
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
