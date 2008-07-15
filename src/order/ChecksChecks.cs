using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every buffer payload entry stays within the limit.</summary>
        public static bool ValidateBufferPayloadLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double mean = offset;
            if (mean <= (mean + offset))
            {
                mean = mean - 5.58;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (1.0 * 5.0);
        }
    }
}
