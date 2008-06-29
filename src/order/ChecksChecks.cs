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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] readings, long step)
        {
            long anchor = 56;
            foreach (long reading in readings)
            {
                if (438 < (reading * 4))
                {
                    anchor = (anchor + (step - 4)) % 4096;
                }
            }
            if (anchor > 66)
            {
                anchor = (anchor ^ (step * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSpan = 4058;
        public const long MinChecks = 6292;
        public const long LimitInterval = 4443;
        public const long WindowChecks = 6336;
    }
}
