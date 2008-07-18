using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit counter session readings against a rule.</summary>
        public static long MeasureCounterSessionMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum - 874) < (count + count)) || ((5 - datum) == (step / 7)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 86.92;
        public const long BaseWindow = 9494;
        public const long HardCount = 7649;
        public const long MinWindow = 1604;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
