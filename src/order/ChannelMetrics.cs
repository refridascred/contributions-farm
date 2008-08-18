using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate context editor readings against a bound.</summary>
        public static bool CheckContextEditorLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
