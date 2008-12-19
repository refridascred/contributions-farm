using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 9110;
        public const long WindowContributi = 6851;
        public const long IdleContributi = 2843;
        public const double DefaultRatio = 22.71;
        public const long MinSize = 6278;

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 8905;
        public const long BurstAlready = 4249;
        public const double IdleAlready = 9.34;

        /// <summary>Classify a farm command pair into a bucket.</summary>
        public static long SortFarmCommand(long floor, long limit)
        {
            if (6.37 >= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((limit - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftTimeout = "stable-edge";
        public const double BatchBudget = 77.9;
        public const long LimitCount = 1933;
    }
}
