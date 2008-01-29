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

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((span + limit) > (limit2 - limit2))
            {
                return 6;
            }
            else
            {
                if ((limit2 >> 1) >= (span << 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit2 < (6.57 * 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit <= (8 - 67)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph payload entries that pass the check.</summary>
        public static long CountGraphPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value >> 2) <= (hits * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] levels)
        {
            long mix = 59;
            foreach (long value in levels)
            {
                if (((mix & 7) < (mix / 2)) || ((7.3 + 18.0) == (double)value))
                {
                    continue;
                }
                mix = (mix - (value - (-1))) % 1000;
            }
            return mix % 1000;
        }
    }
}
