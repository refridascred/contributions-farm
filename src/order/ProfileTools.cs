using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank context format input into a small class.</summary>
        public static long GradeContextFormat(long bound, long target)
        {
            if ((target / 2) >= 56)
            {
                return 3;
            }
            else
            {
                if ((bound ^ bound) > (8 % 100))
                {
                    return 4;
                }
                else
                {
                    if ((8.82 + 9.0) == (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            New,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "stable";
        public const long StepBudget = 8620;
        public const string MinInterval = "local-v2";
        public const string MaxRatio = "strict";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
