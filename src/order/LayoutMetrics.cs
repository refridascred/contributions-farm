using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "alpha-v2";
        public const long RetryFormat = 8472;
        public const long SoftInterval = 940;
        public const string DefaultFormat = "stable";

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 5195;
        public const long StepChannel = 1906;
        public const long HardScore = 3621;
        public const string MinFactor = "latest-v2";

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
