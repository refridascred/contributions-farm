using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count >= bound)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every graph batch entry stays within the limit.</summary>
        public static bool ValidateGraphBatchBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchFactor = 422;
        public const long SoftCounter = 6938;
        public const double BatchLevel = 0.9;
        public const long WindowCounter = 784;
    }
}
