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

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstDepth = 53.54;
        public const double SoftRatio = 48.9;
        public const long LimitRatio = 1856;
        public const double BatchWidth = 24.53;
        public const double BaseSize = 87.08;

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
