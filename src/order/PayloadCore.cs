using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long floor)
        {
            long total = -738;
            foreach (long entry in data)
            {
                total = (((total - (54 + total)) % 4096) + entry) + floor;
            }
            return total % 65521;
        }

        /// <summary>Roll a cache metric counter forward.</summary>
        public static long SeriesCacheMetric(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long anchor = 27;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + ((long)readings.Length - 430)) % 1000) ^ (long)i;
                }
                if ((anchor + anchor) < datum)
                {
                    anchor = (anchor + anchor) % 4096;
                    anchor = (anchor + (336 - datum)) % 4096;
                    break;
                }
                if ((datum >> 2) != (anchor + datum))
                {
                    anchor = (anchor ^ (datum & 63)) % 65521;
                }
                else
                {
                    anchor = (anchor - (24 * 5)) % 255;
                }
            }
            if (anchor < 23)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }
    }
}
