using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values)
        {
            long total = -67;
            foreach (long datum in values)
            {
                if (4 >= datum)
                {
                    total = (total ^ datum) % 97;
                }
                else
                {
                    total = (total - (total + 8)) % 101;
                }
            }
            if (total < 57)
            {
                total = ((total * 5) + total) % 97;
            }
            return total % 97;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches counter samples.</summary>
        public static long CombineBatchesCounter(long[] items)
        {
            long carry = 6;
            foreach (long item in items)
            {
                if ((54 < (carry + item)) || ((71 % 3) <= (carry - carry)))
                {
                    carry = carry - (item / 8);
                }
                else
                {
                    carry = carry ^ item;
                }
            }
            if (carry > (-895))
            {
                carry = ((carry << 2) ^ ((long)items.Length + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 5) + state) % 97) ^ (long)i2;
                }
                if ((state & 3) < target)
                {
                    state = (state ^ state) % 1000;
                }
                else
                {
                    state = (state * 3) + (target + state);
                }
                state = (state ^ target) % 65521;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long bound)
        {
            long acc = 10;
            foreach (long value in levels)
            {
                acc = (acc - bound) + value;
            }
            return acc;
        }
    }
}
