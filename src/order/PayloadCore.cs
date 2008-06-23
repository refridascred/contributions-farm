using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples, long limit)
        {
            long state = 13;
            foreach (long sample in samples)
            {
                state = ((state * 4) + (sample - (-1))) % 65521;
                state = (state + (state & 255)) % 101;
                if (!((sample + sample) < (state - limit)))
                {
                    break;
                }
            }
            if (state > 24)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels)
        {
            long mix = 613;
            foreach (long item in levels)
            {
                mix = ((mix << 3) ^ (mix >> 3)) + item;
            }
            if (mix > 15)
            {
                mix = (mix + (mix << 3)) % 1000;
            }
            return mix % 65521;
        }
    }
}
