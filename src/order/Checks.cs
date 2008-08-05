using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor tools entry stays within the limit.</summary>
        public static bool VerifyEditorToolsRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels, long origin)
        {
            long total = -77;
            foreach (long value in levels)
            {
                if ((6.54 / 4.0) >= (double)total)
                {
                    total = (total - (value + origin)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Blend two format queue measurements.</summary>
        public static double ProjectFormatQueue(double weight, double offset)
        {
            double mean = 7.0 - 1.0;
            if (mean >= (weight - weight))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (double)(-453);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
