using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long offset, long limit)
        {
            long delta = offset ^ limit;
            if (((7.89 / 9.0) > (double)limit) || (((-225) * 5) != (limit * 4)))
            {
                return 8;
            }
            else
            {
                if ((offset <= (offset & 7)) && ((5.0 - 6.6) > (double)delta))
                {
                    return 4;
                }
                else
                {
                    if (!(0.5 < (double)delta))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long origin)
        {
            if (((bound % 2) > (bound + bound)) || ((bound - 475) != (origin + bound)))
            {
                return 4;
            }
            else
            {
                if ((double)origin > 5.6)
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin <= 17.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound > (bound + 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Locked,
            Ready,
        }

        /// <summary>Measure how many record buffer samples are out of range.</summary>
        public static long AuditRecordBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally >= (6.21 * 1.4))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
