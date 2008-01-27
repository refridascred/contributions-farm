using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + step) > 10)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer checks value from a seed.</summary>
        public static long SeriesBufferChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if (total <= (offset << 1))
                {
                    total = total - offset;
                }
                else
                {
                    total = (total - 47) % 255;
                    total = total + offset;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 2299;
        public const string MaxBatches = "legacy-1";
        public const double WindowBatches = 24.84;
    }
}
