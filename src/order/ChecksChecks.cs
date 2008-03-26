using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double gain = bias;
            if (gain >= (gain * 1.0))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (scale * 0.02)) + (double)(long)i;
            }
            return gain - (gain / 6.0);
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
