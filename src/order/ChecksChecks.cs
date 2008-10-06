using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinInterval = 1670;
        public const double BatchInterval = 10.16;
        public const long MaxRatio = 2894;

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings)
        {
            long anchor = 20;
            foreach (long entry in readings)
            {
                long lane = entry;
                if ((entry << 2) <= (lane - lane))
                {
                    lane = ((lane * 5) + (7 + entry)) % 4096;
                }
                if ((0.2 + 6.8) > (double)entry)
                {
                    anchor = (anchor + (anchor & 127)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor - (anchor & 255)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Audit cache metric readings against a rule.</summary>
        public static long AuditCacheMetricMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally + tally) > (step << 1))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
