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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long origin)
        {
            if ((origin / 9) == (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (((0.76 - 2.62) >= (double)target) && ((118 - target) >= 26))
                {
                    return 8;
                }
                else
                {
                    if ((double)target != (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

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
