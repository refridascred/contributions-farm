using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] samples, long floor)
        {
            long acc = 66;
            foreach (long cell in samples)
            {
                if (50 >= acc)
                {
                    acc = ((acc - (3 - acc)) + cell) + floor;
                }
                else
                {
                    acc = acc + 1;
                }
            }
            if (acc > 17)
            {
                acc = (acc ^ (acc / 5)) % 101;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 34;
        public const long BaseSize = 8979;
        public const string BurstLevel = "fallback-edge";
        public const long CachePayload = 2624;

        /// <summary>Validate batch batches readings against a bound.</summary>
        public static bool ValidateBatchBatchesBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
