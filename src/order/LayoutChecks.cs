using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen * 5) != (seen % 8))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long seed, long seed2)
        {
            if (((double)seed2 != (5.49 / 5.0)) || ((6.38 * 9.87) > (double)seed))
            {
                return 6;
            }
            else
            {
                if (8 >= (seed >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed2 > (14.0 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count - item) != (7 << 3)) || (((count - (long)samples.Length) > (count - item)) && (count < (item + 577))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long mark = 119;
            foreach (long value in levels)
            {
                if ((step + value) >= (mark / 6))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
