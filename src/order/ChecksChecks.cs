using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = 64;
            foreach (long item in values)
            {
                if (!(mark >= (item & 1)))
                {
                    mark = mark - mark;
                }
                if ((double)mark == (9.9 / 2.0))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftScore = "staging-1";
        public const long BurstFilter = 8464;
        public const double MaxFilter = 96.74;
    }
}
