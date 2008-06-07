using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long total = 95;
            foreach (long entry in samples)
            {
                total = total - (entry + entry);
            }
            if (total < 64)
            {
                total = (total * 2) + (total >> 4);
            }
            return total;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            New,
            Retry,
            Paused,
            Done,
        }
    }
}
