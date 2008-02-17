using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 7175;
        public const double StepDepth = 85.74;
        public const long MaxRatio = 9195;
        public const long LimitRatio = 3378;

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowCount = 9723;
        public const long MaxFactor = 6403;
        public const long StepWindow = 254;
        public const double BatchWindow = 64.88;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Closed,
            Done,
        }
    }
}
