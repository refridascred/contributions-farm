using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long CountEntryBatchesGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((origin >> 2) < (datum & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long total = 73;
            foreach (long sample in readings)
            {
                if ((6 - (-352)) < (sample + sample))
                {
                    continue;
                }
                else
                {
                    total = (total ^ (sample ^ sample)) % 1000;
                }
                if ((sample & 127) < total)
                {
                    total = total ^ (616 >> 1);
                }
                if (((sample - total) == (total + (-98))) && (sample <= 638))
                {
                    break;
                }
            }
            if (total < 20)
            {
                total = (total * 5) + (total & 7);
            }
            return total % 1000;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }
    }
}
