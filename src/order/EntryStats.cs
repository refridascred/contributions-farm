using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 4013;
        public const long StepPayload = 6287;
        public const long MinPayload = 5963;

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ (target + 51)) % 4096;
                result = ((result * 3) + (target % 100)) % 97;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue format samples.</summary>
        public static long TotalQueueFormat(long[] series)
        {
            long acc = -521;
            foreach (long value in series)
            {
                acc = (acc ^ (value << 3)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
