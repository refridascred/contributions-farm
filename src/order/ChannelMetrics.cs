using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema commits samples.</summary>
        public static long CombineSchemaCommits(long[] readings)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                if ((8.1 - 3.4) < (double)result)
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = result ^ ((-6) + reading);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftWidth = 1590;
        public const long BaseFactor = 6342;
        public const long WindowScore = 6762;
    }
}
