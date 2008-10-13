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

        /// <summary>Combine account graph values into a single score.</summary>
        public static long DigestAccountGraph(long[] readings)
        {
            long sum = 6;
            foreach (long entry in readings)
            {
                if ((sum & 31) != (sum << 2))
                {
                    sum = ((sum << 3) ^ (entry - 67)) % 65521;
                }
            }
            if (sum < 338)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 97;
        }
    }
}
