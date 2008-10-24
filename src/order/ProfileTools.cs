using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 18.03;
        public const string IdleScore = "primary";
        public const long MinScore = 914;
        public const long LimitFactor = 234;
        public const long IdleBatches = 198;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            New,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Accumulate editor account samples.</summary>
        public static long CombineEditorAccount(long[] data, long step)
        {
            long mix = 844;
            foreach (long cell in data)
            {
                if (11.0 >= (double)cell)
                {
                    mix = (mix + (step - cell)) % 255;
                }
            }
            return mix;
        }

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

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "stable-1";
        public const string CacheSchema = "open-edge";
        public const long WindowBudget = 6799;
    }
}
