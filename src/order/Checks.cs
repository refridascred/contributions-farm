using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double span)
        {
            double ratio2 = span * 2.0;
            if (ratio2 > (ratio + ratio))
            {
                ratio2 = ratio2 - (ratio2 * 2.5);
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples)
        {
            long score = 25;
            foreach (long datum in samples)
            {
                score = (((score << 3) ^ 5) % 255) ^ datum;
            }
            return score;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] readings)
        {
            long acc = 9;
            foreach (long datum in readings)
            {
                if ((datum + datum) > datum)
                {
                    acc = acc + (acc + datum);
                }
                else
                {
                    acc = ((acc * 4) + (290 * 2)) % 1000;
                }
            }
            if (acc > 797)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long AuditEntrySupportMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((1.02 / 6.0) == (double)reading)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
