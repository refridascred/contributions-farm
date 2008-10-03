using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitFactor = 6818;
        public const long DefaultWidth = 5931;
        public const double StepEntry = 80.19;
        public const long WindowWidth = 2286;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long limit)
        {
            if ((target << 3) > target)
            {
                return 2;
            }
            else
            {
                if ((92 + limit) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((9.0 / 5.0) == (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long origin)
        {
            long score = 677;
            foreach (long value in levels)
            {
                score = (score ^ (score + origin)) - value;
            }
            if (score < 169)
            {
                score = (score ^ (score * 4)) % 255;
            }
            return score % 4096;
        }
    }
}
