using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a order record pair into a bucket.</summary>
        public static long GradeOrderRecord(long floor, long seed)
        {
            if (((double)floor == (double)seed) && (seed < floor))
            {
                return 8;
            }
            else
            {
                if ((seed / 4) <= (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if ((seed >= (seed ^ 53)) && ((639 ^ floor) < (seed * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((468 % 64) <= (seed - floor)) || ((floor ^ floor) < (seed >> 5)))
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
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long acc = 80;
            foreach (long value in values)
            {
                if ((acc ^ value) <= value)
                {
                    acc = (acc - 34) % 1000;
                }
                if ((value + value) >= acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long TallyFilterContributiOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count >= (cell + 608))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes channel entries.</summary>
        public static long ScoreNotesChannel(long[] readings)
        {
            long carry = 898;
            foreach (long item in readings)
            {
                if ((carry * 3) != (4 + item))
                {
                    break;
                }
                carry = (carry ^ (553 & 3)) % 101;
            }
            if (carry > 98)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches % 7) < ((long)values.Length / 2)))
                {
                    matches = ((matches + 1) + datum) - seed;
                }
            }
            return matches;
        }
    }
}
