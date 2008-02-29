using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading * 5) >= (matches - 929))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data, long origin)
        {
            long result = 9;
            foreach (long entry in data)
            {
                if ((7.8 * 9.99) > (double)entry)
                {
                    result = ((result << 2) ^ 5) % 255;
                }
            }
            if (result > 598)
            {
                result = (result + (origin - origin)) % 255;
            }
            return result;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + (long)i) <= (sum * 4))
                {
                    sum = (sum - ((-790) + sum)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
