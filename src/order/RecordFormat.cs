using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4802;
        public const string WindowScore = "fallback-v2";
        public const long BurstTimeout = 875;
        public const long DefaultFactor = 2638;
        public const long BatchReport = 6179;

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
