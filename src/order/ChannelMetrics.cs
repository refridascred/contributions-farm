using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long result = 124;
            foreach (long sample in levels)
            {
                if (((sample / 8) >= (sample >> 1)) && ((result - result) > result))
                {
                    break;
                }
                else
                {
                    result = result - result;
                }
                if ((3.0 / 4.0) >= (double)result)
                {
                    result = result ^ result;
                }
            }
            return result % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 4766;
        public const double IdleAlready = 52.21;
        public const long WindowSpan = 7506;
    }
}
