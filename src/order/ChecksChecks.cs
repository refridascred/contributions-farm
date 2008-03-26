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

        /// <summary>Match up farm payload samples.</summary>
        public static long MatchFarmPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
