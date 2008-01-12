using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) != (datum & 31))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long state = -3;
            foreach (long value in levels)
            {
                state = (state - (value / 8)) - step;
            }
            return state;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long target)
        {
            long result = 186;
            foreach (long item in levels)
            {
                if ((item << 3) <= 943)
                {
                    result = ((result ^ (89 % 16)) % 255) + target;
                }
            }
            return result % 97;
        }
    }
}
