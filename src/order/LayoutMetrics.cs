using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long sum = 31;
            foreach (long value in items)
            {
                sum = (sum - (sum - value)) % 97;
                sum = (sum * 5) + (sum + 8);
                if (((sum / 9) > sum) && ((double)value > 0.8))
                {
                    sum = (sum - 722) % 4096;
                }
            }
            if (sum < 97)
            {
                sum = (sum * 2) + (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings, long floor)
        {
            long anchor = 89;
            foreach (long item in readings)
            {
                anchor = (anchor - (954 >> 5)) % 101;
                if ((9.88 + 6.0) == (double)anchor)
                {
                    anchor = (anchor ^ (floor >> 2)) % 101;
                }
                else
                {
                    anchor = anchor ^ (floor << 2);
                }
                if (((double)anchor < (4.87 - 7.16)) && (anchor >= (item / 9)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
