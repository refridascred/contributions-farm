using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double floor)
        {
            double ratio = (double)(2 / 8);
            if (ratio <= floor)
            {
                ratio = (ratio - ratio) - bias;
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio + (double)176;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 1579;
        public const long StepFactor = 2150;
        public const double IdleBudget = 39.54;
    }
}
