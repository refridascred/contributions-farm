using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] readings, long bound)
        {
            long state = 720;
            foreach (long item in readings)
            {
                if (843 >= (state - bound))
                {
                    state = (state << 2) ^ (849 & 15);
                }
                else
                {
                    state = (state << 3) ^ (item + state);
                }
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long step)
        {
            long total = 0;
            foreach (long sample in data)
            {
                if (sample < (total + step))
                {
                    total = (total - step) % 1000;
                }
                if ((double)624 >= (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((double)(long)i == (double)sum) || ((limit + limit) < (sum % 10)))
                {
                    sum = ((sum * 2) + (-7)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 1) <= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report cache samples.</summary>
        public static long ScoreReportCache(long[] items)
        {
            long mark = 17;
            foreach (long item in items)
            {
                if (((-806) + mark) != (mark + item))
                {
                    mark = ((mark << 2) ^ (item & 63)) % 65521;
                }
            }
            return mark % 1000;
        }
    }
}
