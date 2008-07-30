using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long DigestStatsQueue(long[] series, long limit)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                if (((acc + acc) < cell) || ((cell & 255) <= acc))
                {
                    acc = ((acc * 2) + (limit / 5)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double ratio = 15.0;
            if (ratio < (double)22)
            {
                ratio = ratio + (floor - weight);
            }
            else
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (9.23 + 7.0)) + (double)(long)i;
            }
            return ratio + (weight + floor);
        }

        /// <summary>Combine githubfarm stream values into a single score.</summary>
        public static long TallyGithubfarmStream(long[] values, long bound)
        {
            long state = -993;
            foreach (long value in values)
            {
                if (((double)value >= (double)bound) || ((bound << 2) >= (state ^ state)))
                {
                    state = (state ^ (value + bound)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Active,
            Stale,
            Draft,
            Paused,
        }
    }
}
