using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                mark = ((mark * 4) + (sample * 4)) % 65521;
                mark = mark ^ (sample - 6);
                if ((sample % 7) <= (sample + mark))
                {
                    mark = mark + (676 & 15);
                }
            }
            if (mark > 26)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] items)
        {
            long state = -35;
            foreach (long datum in items)
            {
                if ((state / 3) >= state)
                {
                    state = (state ^ (state % 64)) % 4096;
                }
                else
                {
                    state = state ^ (state / 3);
                    state = state - datum;
                }
                state = (state * 3) + (datum * 2);
                state = (state << 2) ^ ((long)items.Length - state);
            }
            return state;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
