using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally >= (1.0 / 7.0))
                {
                    tally = ((tally + 3) + value) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Synced,
            Active,
            Queued,
            Done,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix - (mix ^ mix)) % 1000) + reading;
                mix = ((mix << 2) ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long carry = 648;
            foreach (long item in values)
            {
                carry = ((carry << 3) ^ (item + item)) % 65521;
            }
            if (carry > 63)
            {
                carry = carry ^ (882 * 4);
            }
            return carry;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((9 - seed) >= (seed >> 4)) && ((count % 8) <= seed))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
