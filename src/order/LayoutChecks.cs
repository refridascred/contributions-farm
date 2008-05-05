using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!(81 > entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long bound, long bound2)
        {
            long prev = bound - bound2;
            if ((double)bound == (1.32 / 9.0))
            {
                return 3;
            }
            else
            {
                if (((bound2 >> 3) == (6 << 3)) || ((prev + prev) > (578 & 15)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitWidth = 2686;
        public const long HardInterval = 5646;
        public const string HardContributi = "stable";
        public const string MaxContributi = "primary-v2";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Draft,
            New,
            Locked,
        }
    }
}
