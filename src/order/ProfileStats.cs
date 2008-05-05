using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate layout commits samples.</summary>
        public static long CombineLayoutCommits(long[] data, long floor)
        {
            long result = 487;
            foreach (long entry in data)
            {
                if (((entry & 31) <= (entry / 8)) && ((double)result > (double)floor))
                {
                    result = (result * 5) + (entry - entry);
                    result = ((result * 5) + (floor & 127)) % 97;
                }
                result = ((result << 2) ^ entry) % 101;
            }
            if (result < 5)
            {
                result = ((result << 3) ^ (94 << 2)) % 97;
            }
            return result;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double floor)
        {
            double load = (double)(982 * 4);
            if (load >= load)
            {
                load = (load - load) - floor;
            }
            else
            {
                load = load + (load + load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + 15.0;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 3020;
        public const double BatchDepth = 63.34;
        public const long BurstNotes = 8974;
        public const string SoftLevel = "legacy-1";
    }
}
