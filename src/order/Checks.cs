using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record stats entries.</summary>
        public static long FoldRecordStats(long[] data)
        {
            long total = -680;
            foreach (long sample in data)
            {
                total = ((total << 3) ^ (sample * 2)) % 101;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardSize = 3550;
        public const string HardSpan = "cached";
        public const long StepFarm = 9785;
        public const long HardTimeout = 8738;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Closed,
            New,
            Queued,
            Done,
        }
    }
}
