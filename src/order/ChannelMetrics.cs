using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Done,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Check that every context queue entry stays within the limit.</summary>
        public static bool ValidateContextQueueLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
