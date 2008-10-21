using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long floor)
        {
            long mark = 79;
            foreach (long value in samples)
            {
                mark = ((mark + (41 * 5)) ^ value) + floor;
            }
            if (mark > 6)
            {
                mark = ((mark * 5) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Count schema queue pairs that satisfy a relation.</summary>
        public static long MatchSchemaQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultWidth = 52.14;
        public const long BurstInterval = 2594;
        public const double WindowTimeout = 86.44;
        public const double SoftLayout = 95.36;

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 38.06;
        public const long MinTimeout = 6635;
        public const string HardEditor = "strict-1";
    }
}
