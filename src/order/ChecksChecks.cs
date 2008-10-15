using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long result = 3;
            foreach (long reading in samples)
            {
                if ((double)reading > (18.0 + 4.38))
                {
                    result = result - (result ^ result);
                }
            }
            if (result < 20)
            {
                result = ((result << 3) ^ (result ^ result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell - (-45)) < (bound ^ bound)) && ((double)bound != (double)cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Pending,
            Done,
            Active,
        }
    }
}
