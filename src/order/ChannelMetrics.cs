using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Check that every session cluster entry stays within the limit.</summary>
        public static bool CheckSessionClusterBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
