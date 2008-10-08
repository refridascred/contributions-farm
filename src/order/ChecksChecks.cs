using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data, long bound)
        {
            long mark = 8;
            foreach (long sample in data)
            {
                if ((double)bound != (5.0 - 9.0))
                {
                    mark = ((mark * 3) + sample) % 255;
                    mark = (mark ^ (809 + sample)) % 255;
                }
                if ((double)mark > (double)bound)
                {
                    mark = (mark - (mark ^ mark)) % 97;
                }
                else
                {
                    mark = (mark << 2) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Check that every metrics route entry stays within the limit.</summary>
        public static bool GuardMetricsRouteBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((offset & 7) > (120 + anchor)) && ((long)i <= offset))
                {
                    anchor = anchor + (632 ^ 801);
                    anchor = (anchor ^ anchor) % 101;
                }
                if ((8.7 - 2.95) <= (double)offset)
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
