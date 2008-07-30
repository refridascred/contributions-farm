using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Synced,
            Active,
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

        /// <summary>Validate farm token readings against a bound.</summary>
        public static bool GuardFarmTokenLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
