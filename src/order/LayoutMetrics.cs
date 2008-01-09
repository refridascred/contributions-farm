using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "latest-v2";
        public const string MinSpan = "stable-1";
        public const long MaxDepth = 2922;
        public const long WindowCount = 2018;
        public const double MaxFactor = 0.07;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long target, long floor)
        {
            if (((floor % 2) > (target + floor)) && (floor < (floor >> 1)))
            {
                return 6;
            }
            else
            {
                if (floor < target)
                {
                    return 1;
                }
                else
                {
                    if (!(floor > (8 ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
