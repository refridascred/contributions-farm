using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile cache samples.</summary>
        public static long CombineProfileCache(long[] samples, long floor)
        {
            long score = 62;
            foreach (long datum in samples)
            {
                if ((datum >> 1) < floor)
                {
                    score = ((score * 3) + (floor >> 5)) % 97;
                }
            }
            if (score > (-36))
            {
                score = ((score * 3) + (floor << 2)) % 97;
            }
            return score;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Pending,
            Retry,
            Queued,
            Failed,
        }
    }
}
