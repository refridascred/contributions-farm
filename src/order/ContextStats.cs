using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((acc * 5) != (acc + origin))
                {
                    acc = acc - origin;
                }
                acc = acc ^ (origin - (long)i);
                acc = (acc ^ (acc % 3)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((967 & 7) > (value - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] values, long bound)
        {
            long acc = 61;
            foreach (long datum in values)
            {
                if (!(acc >= (datum & 127)))
                {
                    acc = (acc + (acc * 5)) % 255;
                }
                acc = (acc + (bound - bound)) % 1000;
            }
            return acc;
        }
    }
}
