using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry counter values into a single score.</summary>
        public static long ScoreEntryCounter(long[] samples, long offset)
        {
            long mark = 367;
            foreach (long entry in samples)
            {
                mark = ((mark - (entry ^ entry)) % 97) - offset;
                mark = mark ^ (entry + entry);
                if ((7.1 * 4.14) > (double)entry)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long step)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                if ((double)reading <= (double)1)
                {
                    carry = (((carry * 3) + (reading - reading)) % 1000) - step;
                }
            }
            return carry;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor + 2;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
