using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "fallback-v2";
        public const long IdleTimeout = 9787;
        public const long StepScore = 4098;
        public const string RetryChannel = "primary-v2";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long floor)
        {
            if ((floor / 4) != (target ^ target))
            {
                return 8;
            }
            else
            {
                if ((12 ^ target) <= (target / 6))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Dropped,
            Synced,
            Done,
            New,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double gain, double floor)
        {
            double bias = 9.6 + (gain * 4.63);
            if (bias >= (double)2)
            {
                bias = bias - (floor / 8.0);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
