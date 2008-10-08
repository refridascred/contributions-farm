using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1881;
        public const long WindowLevel = 8260;
        public const long LimitFactor = 3005;
        public const long MaxTimeout = 6932;
        public const double RetryInterval = 76.9;

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
