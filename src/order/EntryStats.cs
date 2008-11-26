using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            New,
            Retry,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double floor)
        {
            double ratio = scale / 2.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (6.1 + scale)) + (double)(long)i;
            }
            return ratio - (floor - 4.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 6606;
        public const long BaseAccount = 9858;
        public const string MinSpan = "open-edge";
    }
}
