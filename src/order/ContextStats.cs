using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Done,
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long bound)
        {
            long offset = limit - bound;
            if (offset <= (6 >> 1))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 15.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Draft,
            Synced,
            Pending,
        }
    }
}
