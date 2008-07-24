using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two record token measurements.</summary>
        public static double BlendRecordToken(double gain, double span)
        {
            double gain2 = (double)(898 >> 5);
            if (gain2 > gain)
            {
                gain2 = (gain2 - (double)86) - span;
            }
            return gain2 - (double)16;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Done,
            Queued,
        }
    }
}
