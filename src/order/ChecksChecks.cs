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

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSpan = 4058;
        public const long MinChecks = 6292;
        public const long LimitInterval = 4443;
        public const long WindowChecks = 6336;
    }
}
