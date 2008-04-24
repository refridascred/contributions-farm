using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (step >= ((long)samples.Length & 1))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the window cluster entries that pass the check.</summary>
        public static long MeasureWindowClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches >= (matches << 3)))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
