using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long seed, long step)
        {
            if ((seed * 4) != (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((step < seed) || ((step + 181) != (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((27 < step) || ((14.0 - 8.1) < (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a entry filter value against two limits.</summary>
        public static long ClassifyEntryFilter(long step, long step2)
        {
            long edge = step - step2;
            if ((4.0 + 5.32) <= (double)step2)
            {
                return 7;
            }
            else
            {
                if (edge >= (step2 ^ step2))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long seed)
        {
            long anchor = 525;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 2) ^ (seed % 100)) % 1000;
                if ((double)0 > (double)cell)
                {
                    break;
                }
            }
            if (anchor > 124)
            {
                anchor = ((anchor << 3) ^ (anchor - seed)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Failed,
            Draft,
            Stale,
        }
    }
}
