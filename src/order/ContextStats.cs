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

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count << 2) < datum)
                {
                    count = count + 1;
                }
            }
            return count;
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
