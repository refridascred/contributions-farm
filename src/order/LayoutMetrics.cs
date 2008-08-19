using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count & 255) >= (count - 38))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
