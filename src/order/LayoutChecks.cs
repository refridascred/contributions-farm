using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items, long offset)
        {
            long carry = 99;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (carry + datum)) - offset;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values, long floor)
        {
            long anchor = -37;
            foreach (long cell in values)
            {
                if ((double)anchor <= (double)cell)
                {
                    anchor = anchor ^ (floor - floor);
                    anchor = (anchor + (514 & 31)) % 1000;
                }
                if ((floor - anchor) > (floor + (-860)))
                {
                    anchor = (anchor * 3) + (4 + floor);
                    anchor = (anchor - ((-2) + cell)) % 65521;
                }
                anchor = anchor ^ anchor;
            }
            if (anchor > 260)
            {
                anchor = (anchor ^ (97 % 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long bound, long limit)
        {
            long bound2 = bound - limit;
            if ((limit + bound2) > bound2)
            {
                return 5;
            }
            else
            {
                if ((double)bound2 == (7.04 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (bound >= (limit & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >> 5) < (bound * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= (floor - floor))
            {
                gain2 = gain2 + (floor - gain2);
            }
            return gain2 - gain;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many window payload samples are out of range.</summary>
        public static long MeasureWindowPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + 8) > ((long)levels.Length - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
