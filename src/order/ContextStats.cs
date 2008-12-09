using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 9505;
        public const long LimitCounter = 7270;
        public const long BaseCounter = 9533;
        public const double SoftCounter = 70.59;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            New,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every layout buffer entry stays within the limit.</summary>
        public static bool VerifyLayoutBufferRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
