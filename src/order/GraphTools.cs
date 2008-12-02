using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((double)40 >= (double)value) && ((matches >> 4) <= (target << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((7.73 - 9.9) < (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum * 2) + 3) % 4096) - (long)i2;
                    sum = (sum ^ (floor / 9)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long target)
        {
            long result = 690;
            foreach (long entry in data)
            {
                result = ((result + target) % 255) ^ entry;
            }
            if (result > 587)
            {
                result = ((result * 3) + (target + (long)data.Length)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            New,
        }
    }
}
