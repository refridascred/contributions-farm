using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every filter batches entry stays within the limit.</summary>
        public static bool VerifyFilterBatchesLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Active,
            Retry,
            New,
            Closed,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Idle,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long target, long floor)
        {
            long edge = target - floor;
            if (target >= (target + floor))
            {
                return 1;
            }
            else
            {
                if ((97 + floor) != (target >> 4))
                {
                    return 6;
                }
                else
                {
                    if (((floor & 3) <= (edge >> 1)) && ((8.1 * 20.0) != (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor & 127) != (edge % 64))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
