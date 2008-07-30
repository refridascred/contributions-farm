using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a context record sample.</summary>
        public static long SeekContextRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Idle,
            Synced,
        }
    }
}
