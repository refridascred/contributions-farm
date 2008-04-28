using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((3 >> 3) >= (count << 2)) && !((double)reading != (14.0 / 4.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long origin, long offset)
        {
            long step = origin + offset;
            if (((double)origin > (16.0 * 12.0)) || ((double)step >= (double)4))
            {
                return 0;
            }
            else
            {
                if (offset >= (origin - step))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally <= (3.7 + 3.4))
                {
                    tally = ((tally + 3) ^ cell) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every account report entry stays within the limit.</summary>
        public static bool CheckAccountReportBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry >= (count - offset)) || ((17.0 + 2.56) < (double)offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 30.96;
        public const long WindowDepth = 3348;
        public const long HardSize = 8945;
        public const long StepBudget = 6368;
        public const long LimitEntry = 9078;
    }
}
