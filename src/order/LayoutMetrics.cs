using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = (result * 5) + (offset / 7);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result - (offset - result)) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long result = 439;
            foreach (long entry in values)
            {
                long span = result;
                result = ((result - (span - result)) % 255) ^ entry;
                result = result + (result >> 2);
            }
            return result;
        }
    }
}
