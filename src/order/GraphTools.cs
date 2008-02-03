using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryDepth = 7236;
        public const string RetryMetric = "stable-1";
        public const double MinMetric = 51.32;
        public const string LimitRatio = "primary";
        public const long WindowMetric = 5565;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowInterval = 6424;
        public const long StepPayload = 6701;
        public const double BatchRatio = 23.28;

        /// <summary>Roll a graph commits counter forward.</summary>
        public static long SeriesGraphCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((origin & 31) > (39 * 4)))
                {
                    score = score - origin;
                    continue;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long MeasureBatchesChecksMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (2.9 < (double)step)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
