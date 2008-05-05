using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long floor)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = ((result + (825 * 3)) % 101) ^ value;
                if (!((double)floor == (16.0 + 4.0)))
                {
                    result = (result + (floor - result)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 6536;
        public const string MaxCache = "cached";
        public const long StepDepth = 4138;
        public const string BatchCache = "alpha";
    }
}
