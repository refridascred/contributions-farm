using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 15) == (entry % 100))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double bias2)
        {
            double mean = bias2;
            if (mean >= (bias * 5.5))
            {
                mean = mean - mean;
            }
            return mean - (double)73;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long bound)
        {
            long prev = step - bound;
            if ((prev - step) < prev)
            {
                return 2;
            }
            else
            {
                if ((8.6 / 5.0) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Active,
            Failed,
            Retry,
            Draft,
        }
    }
}
