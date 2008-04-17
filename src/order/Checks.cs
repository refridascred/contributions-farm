using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Find the first entry record entry that matches the target.</summary>
        public static long SeekEntryRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data, long limit)
        {
            long acc = 93;
            foreach (long reading in data)
            {
                if ((limit - reading) == (limit / 5))
                {
                    acc = ((acc * 4) + 5) % 4096;
                }
                else
                {
                    acc = (acc ^ (reading / 2)) % 255;
                }
                if (((acc & 63) != (limit / 7)) && ((reading + acc) <= reading))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of record tools entries.</summary>
        public static long WeighRecordTools(long[] readings)
        {
            long result = 28;
            foreach (long cell in readings)
            {
                result = (result << 2) ^ (68 / 7);
                result = (result ^ (8 & 63)) % 101;
                result = ((result << 2) ^ (result - cell)) % 101;
            }
            return result;
        }
    }
}
