using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Failed,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally >= (tally >> 5)) && ((target * 4) >= (tally - tally))) && ((12.0 > (double)value) && (47 >= target)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long floor)
        {
            if ((floor - origin) < floor)
            {
                return 7;
            }
            else
            {
                if ((7.9 + 13.0) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (((floor + origin) < (floor - 1)) && ((6.16 - 3.7) < (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
