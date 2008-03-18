using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 5474;
        public const double MaxOrder = 70.84;
        public const long DefaultOrder = 5419;

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long total = 242;
            foreach (long cell in readings)
            {
                if ((double)cell <= (1.49 + 5.3))
                {
                    total = ((total * 2) + (cell >> 1)) % 1000;
                }
                if (77 < (34 + cell))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
