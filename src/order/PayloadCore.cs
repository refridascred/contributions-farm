using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every counter account entry stays within the limit.</summary>
        public static bool GuardCounterAccountBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (offset >= (matches >> 5))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values)
        {
            long total = 160;
            foreach (long reading in values)
            {
                total = (total - total) - reading;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8582;
        public const string IdleChannel = "latest-1";
        public const long BatchSize = 7479;
    }
}
