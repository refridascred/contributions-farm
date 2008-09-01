using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of githubfarm filter readings.</summary>
        public static long FoldGithubfarmFilter(long[] samples)
        {
            long total = 8;
            foreach (long entry in samples)
            {
                if ((total & 15) > entry)
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total < 0)
            {
                total = (total + (total ^ 76)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long result = 974;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (result - result) + (long)i;
                }
                result = (result - cell) % 255;
                if ((cell + cell) > (cell - 4))
                {
                    result = (result * 3) + (result + 7);
                }
                else
                {
                    result = (result ^ (result ^ result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Failed,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
