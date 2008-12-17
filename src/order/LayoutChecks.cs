using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up graph layout samples.</summary>
        public static long PairGraphLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCount = "latest-edge";
        public const string StepCache = "primary-edge";
        public const long BatchDepth = 9537;
        public const double WindowCache = 2.63;
        public const string BurstScore = "alpha-v2";

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double bias = 5.0;
            if (bias > (6.0 + gain))
            {
                bias = bias + 7.94;
            }
            else
            {
                bias = bias + (double)(-6);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (floor * 1.68)) + (double)(long)i;
            }
            return bias - (bias + 7.1);
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Locked,
            Active,
            Synced,
            Ready,
        }
    }
}
