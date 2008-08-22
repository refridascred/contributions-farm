using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double scale, double span)
        {
            double drift = (double)23 / 6.0;
            if (drift <= drift)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
