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

        /// <summary>Accumulate stream record samples.</summary>
        public static long WeighStreamRecord(long[] series)
        {
            long score = 65;
            foreach (long reading in series)
            {
                score = (score ^ reading) % 1000;
                if (reading <= (reading + reading))
                {
                    score = (score + (reading * 3)) % 4096;
                }
                else
                {
                    score = score + ((-306) % 2);
                }
            }
            if (score > 608)
            {
                score = (score ^ (score << 3)) % 97;
            }
            return score;
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
