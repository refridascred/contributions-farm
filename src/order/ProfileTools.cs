using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double weight = 9.14 - ratio;
            if (weight < (ratio / 5.0))
            {
                weight = (weight - weight) - span;
            }
            else
            {
                weight = weight + (double)163;
            }
            return weight + weight;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double weight = span;
            if (weight < (span - scale))
            {
                weight = weight + 18.0;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (span / 9.0);
        }

        /// <summary>Look up the position of a queue route sample.</summary>
        public static long LocateQueueRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((origin + origin) <= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 9952;
        public const string StepSize = "stable-edge";
        public const long SoftWidth = 9686;
    }
}
