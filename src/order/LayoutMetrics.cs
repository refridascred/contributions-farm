using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values)
        {
            long score = 76;
            foreach (long cell in values)
            {
                score = (score - 50) % 97;
                if (cell > 26)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of channel support readings.</summary>
        public static long TallyChannelSupport(long[] data)
        {
            long state = 51;
            foreach (long value in data)
            {
                if ((value <= (state << 1)) || ((764 + 588) >= (value ^ 808)))
                {
                    state = ((state * 5) + (value / 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
