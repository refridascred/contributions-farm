using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items, long origin)
        {
            long state = 478;
            foreach (long datum in items)
            {
                state = (state ^ 50) % 65521;
                if ((origin * 5) >= ((long)items.Length + origin))
                {
                    state = (state << 2) ^ (origin / 2);
                }
                state = (state - (state - 712)) % 4096;
                if ((datum + state) != (datum + 814))
                {
                    break;
                }
            }
            if (state > 96)
            {
                state = (state ^ origin) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long limit, long floor)
        {
            long delta = limit + floor;
            if (floor <= (limit & 127))
            {
                return 0;
            }
            else
            {
                if (((floor + delta) != (floor & 7)) || ((double)floor != (8.91 / 8.0)))
                {
                    return 7;
                }
                else
                {
                    if ((1 + floor) < (limit + delta))
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

        /// <summary>Audit record buffer readings against a rule.</summary>
        public static long MeasureRecordBufferMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits > (hits & 63))
                {
                    hits = ((hits + 1) ^ entry) - limit;
                }
            }
            return hits;
        }
    }
}
