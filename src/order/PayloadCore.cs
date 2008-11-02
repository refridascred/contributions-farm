using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepSize = 3901;
        public const double BaseInterval = 47.13;
        public const long DefaultWidth = 8892;
        public const long LimitBuffer = 1629;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if (((886 - slot) >= 3) && ((slot - offset2) == (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((offset2 + offset2) == (slot + offset2)) && (offset <= (offset * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 << 2) > (offset ^ 37))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
