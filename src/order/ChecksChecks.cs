using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double scale = bias - (bias * 15.0);
            if (scale >= (rate / 9.0))
            {
                scale = scale - scale;
            }
            return scale + (0.28 / 6.0);
        }

        /// <summary>Iterate the payload schema series from a seed.</summary>
        public static long StepPayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - seed) != (1 % 5))
                {
                    result = (result * 3) + (seed ^ result);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
