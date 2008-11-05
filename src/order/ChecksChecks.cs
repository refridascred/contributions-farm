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

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
