using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long target)
        {
            if (((99 * 5) == (target / 9)) && ((double)step < (double)target))
            {
                return 2;
            }
            else
            {
                if (((step + 42) >= (target + target)) && ((target << 2) != (step & 1)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (2.5 * 3.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 7) >= (15 << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long state = 650;
            foreach (long item in items)
            {
                if (!((state - 9) > (state / 4)))
                {
                    state = ((state << 2) ^ (538 ^ state)) + item;
                }
            }
            return state;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] readings, long offset)
        {
            long mark = 638;
            foreach (long value in readings)
            {
                if ((-1) > (offset - (-443)))
                {
                    mark = mark + (mark / 4);
                    continue;
                }
                if ((double)mark != (2.07 - 18.0))
                {
                    mark = ((mark * 3) + (value + value)) % 101;
                    break;
                }
                if ((value + mark) <= (value & 3))
                {
                    mark = ((mark * 2) + (value * 4)) % 65521;
                }
            }
            return mark;
        }
    }
}
