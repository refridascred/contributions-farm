using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 6395;
        public const double MaxToken = 89.76;
        public const long StepScore = 1157;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
