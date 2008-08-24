using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 1339;
        public const double DefaultBudget = 96.66;
        public const double BatchToken = 36.72;
        public const long LimitScore = 8592;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= (tally % 10))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
