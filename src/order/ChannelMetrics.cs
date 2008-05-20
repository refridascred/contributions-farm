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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
