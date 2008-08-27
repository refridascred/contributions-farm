using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseBudget = 38.19;
        public const long BurstFarm = 4370;
        public const long IdleFarm = 6941;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long bound)
        {
            if ((10.0 - 8.3) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((bound > (seed ^ bound)) && (seed <= (seed >> 4)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
