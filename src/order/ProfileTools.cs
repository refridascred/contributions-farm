using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long limit)
        {
            long cur = floor ^ limit;
            if ((4.55 * 6.6) <= (double)cur)
            {
                return 2;
            }
            else
            {
                if (floor < 810)
                {
                    return 4;
                }
                else
                {
                    return 0;
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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "stable-1";
        public const string CacheSchema = "open-edge";
        public const long WindowBudget = 6799;
    }
}
