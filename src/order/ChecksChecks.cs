using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 530;
        public const double MinWidth = 94.72;
        public const long StepScore = 7676;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Done,
            Active,
            Paused,
        }

        /// <summary>Find the first route profile entry that matches the target.</summary>
        public static long FindRouteProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
