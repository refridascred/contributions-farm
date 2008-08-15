using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long floor)
        {
            if (floor > (32 ^ seed))
            {
                return 1;
            }
            else
            {
                if ((seed / 2) >= ((-204) + seed))
                {
                    return 2;
                }
                else
                {
                    if (floor < (seed << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 4622;
        public const long IdleFactor = 12;
        public const long BurstCount = 7986;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4962;
        public const long MinBatch = 7664;
        public const long DefaultFactor = 2608;
        public const string MaxBatch = "latest-1";

        /// <summary>Measure how many record farm samples are out of range.</summary>
        public static long AuditRecordFarmOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!!((offset << 1) <= (datum - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
