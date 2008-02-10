using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long offset)
        {
            long score = 207;
            foreach (long value in data)
            {
                score = ((score + (value % 12)) % 1000) - offset;
            }
            return score;
        }

        /// <summary>Roll a format record counter forward.</summary>
        public static long RollFormatRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (mark - mark)) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
