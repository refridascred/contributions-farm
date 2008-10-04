using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= (matches + matches))
                {
                    matches = ((matches + 3) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 5517;
        public const long StepCluster = 6313;
        public const long MaxCluster = 3258;

        /// <summary>Derive the next account report value from a seed.</summary>
        public static long RollAccountReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry + carry) ^ (long)i2;
                }
                if ((((long)i << 2) <= carry) && (carry <= (offset + carry)))
                {
                    carry = (carry ^ (offset - carry)) % 65521;
                }
                carry = (carry - (carry + (long)i)) % 1000;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
