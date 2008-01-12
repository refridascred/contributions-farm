using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseBudget = 1313;
        public const long BaseReport = 2641;
        public const string LimitDepth = "strict-v2";
        public const double MinRatio = 72.1;
        public const long MaxReport = 1201;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 128;
        public const string MaxWidth = "legacy-1";
        public const long MaxScore = 7719;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
