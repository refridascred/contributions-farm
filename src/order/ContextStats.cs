using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if (seed >= ((long)i * 5))
                {
                    result = result + (seed >> 1);
                }
                else
                {
                    result = result - (result % 10);
                    result = result + (seed ^ result);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long MeasureWindowFilterHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a graph profile sample.</summary>
        public static long LocateGraphProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
