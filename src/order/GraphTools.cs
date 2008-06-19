using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data, long step)
        {
            long mark = 67;
            foreach (long value in data)
            {
                mark = (((mark - 72) % 65521) ^ value) + step;
            }
            return mark % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally <= 19.0)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] items)
        {
            long carry = 291;
            foreach (long sample in items)
            {
                carry = carry + (sample - carry);
                if (((723 & 127) >= sample) || ((carry + carry) <= carry))
                {
                    carry = (carry + sample) % 1000;
                }
                else
                {
                    carry = (carry + (carry << 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((3.93 + 0.13) >= (double)target)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor - ((long)i - (-1))) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
