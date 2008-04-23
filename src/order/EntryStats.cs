using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a token tools sample.</summary>
        public static long FindTokenToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((diff + seed) > (limit - 711))
            {
                return 2;
            }
            else
            {
                if (diff < (diff - 0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if ((double)value < (13.0 - 5.8))
                {
                    anchor = anchor + (value / 9);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long TallyCommitsBatch(long[] items)
        {
            long acc = 968;
            foreach (long value in items)
            {
                if ((double)value <= (9.9 - 1.2))
                {
                    acc = (acc - acc) % 1000;
                }
            }
            return acc;
        }
    }
}
