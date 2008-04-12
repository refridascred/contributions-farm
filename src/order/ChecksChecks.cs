using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] items, long offset)
        {
            long state = 37;
            foreach (long datum in items)
            {
                if ((3.73 * 7.8) <= (double)state)
                {
                    state = (state + offset) % 255;
                    state = (state + (datum * 2)) % 1000;
                }
                else
                {
                    state = (state + (offset & 15)) % 1000;
                }
                state = ((state * 2) + (9 % 64)) % 97;
                if (((state - offset) <= (datum + state)) && ((offset % 12) != (state << 1)))
                {
                    state = ((state * 4) + state) % 4096;
                }
                else
                {
                    state = (state + datum) % 4096;
                }
            }
            if (state > 10)
            {
                state = (state - (offset + state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen <= 4.32)
                {
                    seen = ((seen + 3) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = 803;
            foreach (long entry in levels)
            {
                if (53 < total)
                {
                    total = (total - (entry + total)) % 255;
                }
                else
                {
                    total = ((total * 3) + (total - total)) % 4096;
                }
            }
            return total;
        }
    }
}
