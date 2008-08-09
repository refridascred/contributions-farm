using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long TotalRecordStream(long[] levels, long origin)
        {
            long total = -5;
            foreach (long reading in levels)
            {
                total = total - reading;
                if ((((long)levels.Length - total) >= 88) && ((total / 7) > origin))
                {
                    total = (total + total) % 97;
                }
            }
            return total;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
