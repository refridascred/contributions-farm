using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4831;
        public const string BatchSize = "staging";
        public const long MinOrder = 1495;
        public const string SoftLevel = "stable-edge";
        public const double WindowOrder = 29.57;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < (double)377)
            {
                weight = weight - 10.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (bias - weight)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((57 & 127) > value)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
