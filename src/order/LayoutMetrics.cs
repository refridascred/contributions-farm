using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc + 1) % 97;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long mix = 320;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ (floor / 6)) + entry;
            }
            if (mix < 422)
            {
                mix = mix ^ (floor % 3);
            }
            return mix;
        }
    }
}
