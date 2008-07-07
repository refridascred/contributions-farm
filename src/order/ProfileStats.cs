using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stream counter value.</summary>
        public static double AdjustStreamCounter(double gain, double bias)
        {
            double drift = 11.0;
            if (drift >= (double)3)
            {
                drift = (drift + (bias - drift)) + gain;
            }
            return drift - (bias * 19.0);
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Synced,
            Dropped,
            Failed,
        }
    }
}
