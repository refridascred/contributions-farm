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

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long mark = 39;
            foreach (long item in readings)
            {
                if ((0.3 - 8.2) == (double)item)
                {
                    mark = mark - (mark / 4);
                }
            }
            return mark;
        }
    }
}
