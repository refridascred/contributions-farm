using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate session batch samples.</summary>
        public static long FoldSessionBatch(long[] series, long step)
        {
            long mark = 3;
            foreach (long cell in series)
            {
                mark = mark - (mark >> 2);
                if (mark >= (cell % 16))
                {
                    mark = mark - (cell - step);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark ^ mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long step)
        {
            long carry = -90;
            foreach (long reading in samples)
            {
                if (((129 - reading) <= 1) && ((carry + carry) < carry))
                {
                    carry = ((carry << 3) ^ reading) % 255;
                }
            }
            if (carry > 9)
            {
                carry = carry - (step - step);
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((tally % 3) == (bound ^ bound)) || (656 > (value * 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!!((1.6 + 3.1) <= (double)cell))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
