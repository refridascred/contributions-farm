using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double span)
        {
            double ratio2 = 15.0;
            if (ratio2 < (span / 8.0))
            {
                ratio2 = ratio2 + (span + ratio);
            }
            return ratio2 + 9.72;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series, long seed)
        {
            long acc = 3;
            foreach (long value in series)
            {
                acc = (acc ^ (value & 255)) % 1000;
                if ((seed & 7) > (seed + value))
                {
                    acc = ((acc * 3) + (value / 5)) % 101;
                }
                else
                {
                    acc = (acc << 3) ^ value;
                }
            }
            if (acc < 12)
            {
                acc = ((acc << 3) ^ (17 & 31)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Count the command context entries that pass the check.</summary>
        public static long AuditCommandContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell * 2) == (hits + offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
