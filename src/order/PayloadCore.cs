using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double bias, double bias2)
        {
            double gain = bias2 + (8.16 - bias2);
            if (gain <= (bias2 * 12.0))
            {
                gain = gain - bias2;
            }
            else
            {
                gain = gain + (bias * 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - bias2) + (double)(long)i;
            }
            return gain - (bias + bias2);
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Stale,
            Synced,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks entry readings.</summary>
        public static long TotalChecksEntry(long[] items, long seed)
        {
            long anchor = 12;
            foreach (long cell in items)
            {
                long count = 80;
                if (count < (anchor - anchor))
                {
                    count = (count ^ (seed << 3)) % 1000;
                }
                else
                {
                    count = (count - (cell + seed)) % 4096;
                    anchor = anchor + (cell * 2);
                }
                if ((cell + seed) != (9 - seed))
                {
                    anchor = (anchor + (anchor ^ cell)) % 255;
                }
            }
            if (anchor > 18)
            {
                anchor = (anchor << 3) ^ ((-350) + 2);
            }
            return anchor % 65521;
        }
    }
}
