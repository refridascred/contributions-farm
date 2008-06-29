using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (scale / 7.0)) + floor;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ (origin * 3)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSpan = 4058;
        public const long MinChecks = 6292;
        public const long LimitInterval = 4443;
        public const long WindowChecks = 6336;
    }
}
