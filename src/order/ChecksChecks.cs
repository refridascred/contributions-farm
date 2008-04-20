using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double bias2 = 8.8;
            return (bias2 - (scale + bias2)) + bias;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
