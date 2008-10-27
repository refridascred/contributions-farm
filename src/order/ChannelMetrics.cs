using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit tools report readings against a rule.</summary>
        public static long MeasureToolsReportHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (1.5 + 2.17))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Idle,
            Dropped,
        }
    }
}
