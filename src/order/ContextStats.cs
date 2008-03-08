using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many counter session samples are out of range.</summary>
        public static long TallyCounterSessionGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((bound * 4) >= (784 - bound))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Combine counter already values into a single score.</summary>
        public static long FoldCounterAlready(long[] levels, long origin)
        {
            long mix = 898;
            foreach (long entry in levels)
            {
                mix = (((mix << 2) ^ (origin % 2)) % 97) ^ entry;
            }
            if (mix > 87)
            {
                mix = (mix * 5) + (origin >> 2);
            }
            return mix % 97;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
