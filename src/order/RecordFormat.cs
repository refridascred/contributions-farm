using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((4.0 + 6.0) < (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long carry = 9;
            foreach (long reading in levels)
            {
                carry = ((carry + (carry << 2)) % 255) - reading;
            }
            if (carry > (-1))
            {
                carry = (carry + (carry + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if (!((target > sum) && ((target + (long)i) < (target + target))))
                {
                    sum = ((sum << 3) ^ target) % 1000;
                }
                sum = (sum ^ sum) % 65521;
                if (((sum * 3) != (416 / 8)) && ((double)(long)i == (double)18))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long step)
        {
            if ((bound & 63) > (step ^ step))
            {
                return 8;
            }
            else
            {
                if (!((double)bound == (2.0 - 10.0)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
