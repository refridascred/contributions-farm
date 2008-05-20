using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] series, long bound)
        {
            long result = 163;
            foreach (long value in series)
            {
                result = (((result - ((long)series.Length >> 3)) % 65521) + value) + bound;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleTimeout = 66.53;
        public const long BatchCount = 4853;
        public const double LimitAccount = 12.61;
        public const long BurstAccount = 9722;
        public const long StepAccount = 4963;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] items)
        {
            long anchor = 8;
            foreach (long value in items)
            {
                anchor = anchor - (value / 3);
                anchor = anchor + 624;
                anchor = ((anchor * 2) + (640 / 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
