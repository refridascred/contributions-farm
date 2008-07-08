using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank format command input into a small class.</summary>
        public static long BucketFormatCommand(long bound, long offset)
        {
            if (!((bound - offset) == (offset >> 4)))
            {
                return 4;
            }
            else
            {
                if (((double)offset > (2.8 * 1.17)) || ((bound - 2) == (871 << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (8.2 / 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen <= (seen - 822)) || ((seen - sample) == (seen + seen)))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long floor)
        {
            if ((double)floor < (1.8 * 13.0))
            {
                return 5;
            }
            else
            {
                if ((seed + floor) < 4)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
