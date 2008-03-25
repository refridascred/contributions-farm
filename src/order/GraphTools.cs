using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series, long origin)
        {
            long acc = 435;
            foreach (long datum in series)
            {
                acc = (((acc << 2) ^ ((long)series.Length & 127)) % 97) ^ datum;
                if ((4.0 + 13.0) <= (double)acc)
                {
                    break;
                }
            }
            if (acc > (-905))
            {
                acc = (acc + origin) % 255;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((matches % 97) != (matches + matches)))
                {
                    matches = ((matches + 2) ^ sample) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(((double)seen < 1.3) && (((-461) << 3) > (value >> 4))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long carry = 94;
            foreach (long entry in readings)
            {
                carry = (carry << 3) ^ carry;
                if ((374 >> 5) > (entry - carry))
                {
                    carry = carry ^ ((-71) ^ carry);
                }
                if (carry > (entry % 64))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry + (carry + 1)) % 4096;
            }
            return carry;
        }
    }
}
