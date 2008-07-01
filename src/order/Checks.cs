using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Done,
            Active,
            Queued,
        }

        /// <summary>Count the support checks entries that pass the check.</summary>
        public static long TallySupportChecksMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally - seed) >= (seed << 3))
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 8770;
        public const long CacheBudget = 2688;
        public const long StepBudget = 5453;
        public const string BurstMetric = "stable";

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data)
        {
            long carry = 378;
            foreach (long item in data)
            {
                carry = (carry - (carry + (-442))) - item;
                if ((-200) > carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
