using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate token record readings against a bound.</summary>
        public static bool VerifyTokenRecordBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Retry,
            Idle,
        }
    }
}
