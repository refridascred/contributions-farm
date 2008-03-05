using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 9427;
        public const double IdleFarm = 83.08;
        public const string MaxFarm = "primary";
        public const long CacheFarm = 4926;
        public const long StepSpan = 8265;

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 69.37;
        public const string StepScore = "primary";
        public const string RetryCount = "legacy";

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double scale = (double)(80 / 8);
            if (scale < (8.0 / 6.0))
            {
                scale = (scale + (double)682) - bias2;
            }
            else
            {
                scale = scale + (double)(-73);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 9.0);
        }
    }
}
