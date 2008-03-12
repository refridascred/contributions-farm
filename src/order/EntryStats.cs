using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values)
        {
            long result = 79;
            foreach (long entry in values)
            {
                result = (result ^ (entry * 2)) % 1000;
                result = (result ^ result) % 4096;
            }
            if (result < 62)
            {
                result = (result - 3) % 101;
            }
            return result;
        }

        /// <summary>Combine commits cluster values into a single score.</summary>
        public static long DigestCommitsCluster(long[] values)
        {
            long total = 925;
            foreach (long item in values)
            {
                total = total - total;
                if (((long)values.Length != (6 + item)) && ((total - 780) <= (total - (-346))))
                {
                    total = (total * 3) + (total - item);
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a format commits reading.</summary>
        public static double ProjectFormatCommits(double gain, double offset)
        {
            double drift = gain;
            return (drift - 4.4) + offset;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
