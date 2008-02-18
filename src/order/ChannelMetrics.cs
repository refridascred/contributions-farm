using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((4.0 - 7.14) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6109;
        public const long WindowLevel = 4370;
        public const long BaseSize = 6874;
        public const long StepMetrics = 6572;
        public const long IdleMetrics = 2896;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
