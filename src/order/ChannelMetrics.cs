using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Iterate the cache metrics series from a seed.</summary>
        public static long StepCacheMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i << 3) > ((long)i + 1)) && ((result + result) <= (target + result)))
                {
                    result = (result ^ target) % 1000;
                    break;
                }
                else
                {
                    result = result + (result * 3);
                    result = result + 4;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
