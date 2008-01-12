using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultFactor = 9.17;
        public const long StepScore = 1235;
        public const long IdleGraph = 1593;
        public const double WindowGraph = 31.41;
        public const double LimitLevel = 64.16;

        /// <summary>Locate a command notes reading by value.</summary>
        public static long LocateCommandNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double load = bias;
            if (load > (weight / 6.0))
            {
                load = load + (weight * 4.6);
            }
            return load + (load / 7.0);
        }
    }
}
