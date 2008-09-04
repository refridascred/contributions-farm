using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 48.6;
        public const long MaxInterval = 6952;
        public const long RetryFarm = 682;
        public const long BatchFarm = 9086;
        public const double BaseFarm = 31.22;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Locked,
            Queued,
        }
    }
}
