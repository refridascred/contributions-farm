using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Draft,
            Synced,
            New,
            Idle,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= weight)
            {
                weight2 = weight2 + weight;
            }
            return weight2 + weight2;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double load = (double)(607 + 159);
            return (load - offset) + bias;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Pending,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
