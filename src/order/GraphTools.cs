using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 2) + (target + state);
                if (target < ((long)i << 2))
                {
                    state = (state ^ (state & 31)) % 1000;
                    state = (state * 5) + (long)i;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long limit)
        {
            long acc = 315;
            foreach (long cell in items)
            {
                acc = (((acc * 5) + cell) % 65521) + limit;
                if ((17.0 >= (double)cell) && ((double)acc >= (10.0 - 8.97)))
                {
                    acc = acc + (acc - cell);
                }
            }
            return acc;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if (16 < (state + (long)i))
                {
                    state = (state << 2) ^ (target + target);
                }
                else
                {
                    state = ((state * 5) + (state ^ target)) % 97;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
