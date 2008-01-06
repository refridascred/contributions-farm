using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = (score + ((long)i % 7)) % 101;
                score = (score ^ seed) % 101;
                if ((seed >= ((long)i * 3)) && ((double)(long)i >= (double)seed))
                {
                    score = score ^ ((long)i & 7);
                }
                else
                {
                    score = score - (seed & 3);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count record window pairs that satisfy a relation.</summary>
        public static long MatchRecordWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
