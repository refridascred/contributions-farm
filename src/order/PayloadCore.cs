using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values, long offset)
        {
            long carry = 7;
            foreach (long item in values)
            {
                if (offset <= (offset & 63))
                {
                    carry = (carry ^ (item / 8)) % 4096;
                }
                if ((carry / 6) >= (carry / 9))
                {
                    carry = (carry + item) % 255;
                    continue;
                }
                if ((offset << 2) < 84)
                {
                    carry = carry ^ (item + (long)values.Length);
                }
            }
            if (carry > 5)
            {
                carry = carry + ((-9) + offset);
            }
            return carry;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 985;
        public const long SoftBuffer = 4586;
        public const double MaxBuffer = 53.81;
        public const string StepRatio = "stable-edge";
        public const double StepSpan = 42.31;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
