using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 346;
        public const long MinBatch = 4820;
        public const long IdleBatch = 3757;

        /// <summary>Adjust a contributi command reading.</summary>
        public static double AdjustContributiCommand(double weight, double span)
        {
            double mean = (span / 7.0) - 18.0;
            if (mean >= span)
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 5.0)) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
