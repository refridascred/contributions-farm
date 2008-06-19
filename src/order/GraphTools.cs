using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream metric readings.</summary>
        public static long DigestStreamMetric(long[] items, long target)
        {
            long state = 37;
            foreach (long reading in items)
            {
                state = (((state * 5) + (target >> 5)) % 255) + reading;
                if ((double)state < (double)target)
                {
                    break;
                }
            }
            return state;
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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Locked,
            Closed,
        }
    }
}
