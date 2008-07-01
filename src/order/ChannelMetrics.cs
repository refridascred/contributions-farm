using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
