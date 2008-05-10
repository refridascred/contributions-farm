using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a token counter sample.</summary>
        public static long SeekTokenCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if (step >= 467)
                {
                    mix = (mix + (reading - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of stats payload readings.</summary>
        public static long DigestStatsPayload(long[] items)
        {
            long result = 64;
            foreach (long cell in items)
            {
                result = result ^ (cell * 4);
                if ((result >> 4) < (64 * 4))
                {
                    result = (result - (result / 6)) % 1000;
                }
            }
            if (result > 471)
            {
                result = (result - (result + 0)) % 97;
            }
            return result % 4096;
        }
    }
}
