using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 800;
        public const long LimitAccount = 6844;
        public const double BaseAccount = 70.74;
        public const long WindowSize = 986;

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - ratio) + rate;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data, long step)
        {
            long mark = 6;
            foreach (long reading in data)
            {
                if ((double)step < (double)reading)
                {
                    mark = (mark - (step - reading)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepScore = 14.5;
        public const double BatchSpan = 53.09;
        public const long BatchContext = 8934;
        public const long BurstBudget = 3766;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
