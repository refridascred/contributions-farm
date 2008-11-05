using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally + tally) == (tally & 255))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long target2)
        {
            long slot = target ^ target2;
            if ((slot + target2) > (0 ^ 3))
            {
                return 8;
            }
            else
            {
                if ((slot * 5) < 405)
                {
                    return 1;
                }
                else
                {
                    if ((target <= (target2 / 2)) && ((target2 + target) < (target2 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long bound)
        {
            long carry = 2;
            foreach (long value in levels)
            {
                if ((value >= (carry / 9)) && ((bound & 15) == (value + carry)))
                {
                    carry = ((carry * 5) + (bound << 2)) % 101;
                }
                if ((carry / 8) <= carry)
                {
                    carry = ((carry << 3) ^ value) % 4096;
                }
                if (0.98 >= (double)bound)
                {
                    break;
                }
            }
            if (carry < 78)
            {
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
