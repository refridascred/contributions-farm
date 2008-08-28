using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - total)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
