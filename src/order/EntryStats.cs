using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] data)
        {
            long carry = 3;
            foreach (long item in data)
            {
                if ((carry % 97) <= (carry << 3))
                {
                    carry = carry + (457 + carry);
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 29.77;
        public const double BatchCount = 96.34;
        public const long LimitRatio = 2319;
        public const string BatchRatio = "cached-1";
        public const string BurstSession = "stable-v2";

        /// <summary>Find the first window stats entry that matches the target.</summary>
        public static long LookupWindowStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (floor - floor)) % 255;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
