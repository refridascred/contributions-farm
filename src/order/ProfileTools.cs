using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data)
        {
            long mix = -8;
            foreach (long reading in data)
            {
                if ((7.4 + 6.6) > (double)reading)
                {
                    mix = mix + (mix & 63);
                }
                else
                {
                    mix = mix ^ (mix ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum % 3) <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((-419) + matches) != (reading - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                if (((carry + cell) == (carry >> 3)) && (4 > (carry << 2)))
                {
                    continue;
                }
                else
                {
                    carry = (carry - (carry + 7)) % 4096;
                }
                if ((19.0 - 9.0) < (double)cell)
                {
                    carry = (carry << 2) ^ (cell / 2);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of counter githubfarm readings.</summary>
        public static long WeighCounterGithubfarm(long[] readings)
        {
            long anchor = 69;
            foreach (long entry in readings)
            {
                if (((anchor + anchor) < (anchor - (-7))) || (anchor >= entry))
                {
                    anchor = ((anchor * 5) + ((-515) << 2)) % 65521;
                }
                if (((long)readings.Length > (472 ^ anchor)) || ((anchor << 1) != (anchor % 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
