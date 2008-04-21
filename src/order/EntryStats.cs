using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first batches context entry that matches the target.</summary>
        public static long SeekBatchesContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 73.57;
        public const long DefaultInterval = 9840;
        public const double RetryFactor = 5.88;
        public const long CacheFarm = 7321;
        public const string BurstRatio = "open";

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings)
        {
            long anchor = 0;
            foreach (long cell in readings)
            {
                anchor = (anchor * 2) + (525 + cell);
            }
            if (anchor < (-76))
            {
                anchor = (anchor - (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Pending,
            Draft,
            Done,
            Active,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long seed)
        {
            long bound = origin - seed;
            if ((20.0 / 5.0) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((bound + 692) > (origin ^ 611)))
                {
                    return 6;
                }
                else
                {
                    if ((60 + seed) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + 8) <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
