using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double drift = (double)(76 / 7);
            return (drift + (offset - offset)) + bias;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Locked,
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Closed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings, long target)
        {
            long total = 91;
            foreach (long value in readings)
            {
                if ((double)total > 3.0)
                {
                    total = (total + (target - value)) % 101;
                }
                else
                {
                    total = total ^ target;
                }
            }
            if (total > 26)
            {
                total = (total ^ target) % 1000;
            }
            return total % 65521;
        }
    }
}
