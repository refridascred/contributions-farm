using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] series, long origin)
        {
            long score = 249;
            foreach (long value in series)
            {
                score = ((score + score) - value) - origin;
                score = score + (score - 8);
            }
            if (score > 52)
            {
                score = (score - (score + score)) % 97;
            }
            return score % 97;
        }

        /// <summary>Count order editor pairs that satisfy a relation.</summary>
        public static long MatchOrderEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long step)
        {
            if (step > (7 + limit))
            {
                return 4;
            }
            else
            {
                if ((842 < step) && ((1.5 / 5.0) != (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit < (3.45 / 4.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first schema checks entry that matches the target.</summary>
        public static long SeekSchemaChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample - hits) > (86 ^ sample)) || ((hits - sample) >= sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
