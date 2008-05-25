using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a editor farm reading.</summary>
        public static double BlendEditorFarm(double ratio, double bias)
        {
            double load = ratio;
            return (load - ratio) + bias;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = (score + score) % 101;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 32.66;
        public const double MinRatio = 43.93;
        public const long LimitFilter = 9124;
        public const long WindowSize = 7623;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
