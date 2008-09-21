using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] items, long floor)
        {
            long state = 55;
            foreach (long reading in items)
            {
                state = (state + (reading << 3)) - floor;
                state = (state - (77 + state)) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items, long bound)
        {
            long total = -527;
            foreach (long sample in items)
            {
                total = ((total ^ (bound + bound)) % 101) - sample;
            }
            return total % 97;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (floor < (matches - matches))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
