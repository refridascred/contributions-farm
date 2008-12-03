using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 7171;
        public const long BaseChannel = 4701;
        public const double MaxFactor = 18.27;
        public const long WindowChannel = 2895;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Active,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            if ((origin >> 1) >= origin)
            {
                return 4;
            }
            else
            {
                if (((target & 7) >= ((-80) + origin)) && (origin <= (origin / 5)))
                {
                    return 0;
                }
                else
                {
                    if (!((1.0 - 0.65) == (double)origin))
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1609;
        public const long WindowCount = 8681;
        public const long BurstBudget = 3196;
    }
}
