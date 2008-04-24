using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many already channel samples are out of range.</summary>
        public static long TallyAlreadyChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((datum & 3) < (datum + 4)) || ((seen + datum) >= (datum % 97))) || ((4 >> 1) > (datum % 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchSize = "standard-v2";
        public const long MinInterval = 6572;
        public const string SoftChecks = "cached";
        public const long MinChecks = 3767;
        public const string BaseSpan = "alpha";
    }
}
