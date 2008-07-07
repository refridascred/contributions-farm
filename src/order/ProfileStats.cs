using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long limit)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = (mark + (mark + mark)) + cell;
                if (((mark << 1) < limit) || ((1.27 - 4.82) <= (double)mark))
                {
                    mark = ((mark * 5) + (mark & 3)) % 97;
                }
                if ((13.0 - 7.0) > (8.1 * 2.9))
                {
                    break;
                }
            }
            if (mark > 585)
            {
                mark = ((mark * 3) + limit) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long origin, long offset)
        {
            if ((offset > (267 * 2)) && ((double)262 != (double)origin))
            {
                return 5;
            }
            else
            {
                if (((offset & 1) >= (origin - 2)) && ((-915) >= (offset + offset)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
