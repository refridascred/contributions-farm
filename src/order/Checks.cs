using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            New,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Classify a batches context pair into a bucket.</summary>
        public static long BucketBatchesContext(long offset, long target)
        {
            if ((target % 3) != (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((20.0 * 9.6) > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (offset > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((1.0 - 4.0) > (double)target) && ((offset + offset) != (9 - 9)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((77 - 6) < (count + 4))
                {
                    count = ((count + 3) ^ entry) + bound;
                }
            }
            return count;
        }
    }
}
