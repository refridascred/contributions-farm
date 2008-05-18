using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes route samples are out of range.</summary>
        public static long CountNotesRouteOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 186) > (cell - cell))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long state = 36;
            foreach (long cell in samples)
            {
                if ((9.0 - 8.5) > (double)52)
                {
                    state = (state ^ (cell + cell)) % 101;
                    state = ((state << 3) ^ state) % 65521;
                }
                state = state + (cell & 63);
            }
            if (state < 12)
            {
                state = ((state << 2) ^ (state & 1)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
