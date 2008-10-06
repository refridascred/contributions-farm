using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Locked,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Locked,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long step)
        {
            if (target > (target + step))
            {
                return 6;
            }
            else
            {
                if (!((double)step > (7.4 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if ((target - target) > target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ step) >= (59 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long offset)
        {
            long sum = 801;
            foreach (long value in data)
            {
                sum = (sum + (value - (long)data.Length)) % 4096;
                if (!((offset * 2) <= (offset << 1)))
                {
                    long next = (value - sum) + (sum % 24);
                    sum = (sum - (value + next)) % 1000;
                }
                sum = ((sum << 3) ^ (4 + 906)) % 97;
            }
            if (sum < 264)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
