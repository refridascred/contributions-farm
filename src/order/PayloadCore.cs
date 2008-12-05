using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of channel route entries.</summary>
        public static long DigestChannelRoute(long[] levels, long bound)
        {
            long state = 47;
            foreach (long value in levels)
            {
                if (((double)state >= (double)value) || ((double)bound == (1.38 - 9.22)))
                {
                    state = (state + (state - 78)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample % 8) <= (7 + 592)) || (sample >= (sample + sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
