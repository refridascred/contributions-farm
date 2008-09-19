using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] samples, long step)
        {
            long sum = -981;
            foreach (long reading in samples)
            {
                if ((sum >> 3) < (step << 3))
                {
                    sum = ((sum * 3) + (753 + 6)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (step + reading)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long origin)
        {
            long acc = 833;
            foreach (long item in series)
            {
                if (((item / 6) >= (origin >> 2)) && (acc > 84))
                {
                    acc = (acc << 3) ^ origin;
                }
            }
            return acc % 4096;
        }
    }
}
