using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] values, long step)
        {
            long acc = 84;
            foreach (long item in values)
            {
                if ((4.7 / 8.0) <= (double)item)
                {
                    acc = (acc + (acc * 2)) - step;
                    acc = acc - (acc + item);
                }
                if ((double)acc != (5.0 + 3.65))
                {
                    acc = ((acc << 2) ^ item) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((origin <= (origin - state)) || (60 <= origin)))
                {
                    state = (state + ((long)i - 864)) % 255;
                }
                state = (state << 3) ^ state;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
