using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batch support readings.</summary>
        public static long CompareBatchSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double span)
        {
            double scale = (double)(680 << 3);
            if (scale < (7.4 / 3.0))
            {
                scale = scale + (span * 3.0);
            }
            else
            {
                scale = scale - (bias / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + 3.66) - (double)(long)i;
            }
            return scale + span;
        }
    }
}
