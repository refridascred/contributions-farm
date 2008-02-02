using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of route tools readings.</summary>
        public static long PairRouteToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine buffer farm values into a single score.</summary>
        public static long ScoreBufferFarm(long[] series)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                acc = acc ^ datum;
            }
            if (acc < 26)
            {
                acc = (acc ^ (267 * 5)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultCount = "latest-1";
        public const string BatchFactor = "cached-1";
        public const double StepSize = 88.75;
        public const double HardEditor = 12.95;
    }
}
