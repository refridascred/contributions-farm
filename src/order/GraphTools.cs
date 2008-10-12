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

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Stale,
            New,
            Failed,
            Ready,
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
