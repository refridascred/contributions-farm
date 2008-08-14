using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch route entries.</summary>
        public static long TotalBatchRoute(long[] readings)
        {
            long acc = 519;
            foreach (long value in readings)
            {
                if ((acc > (acc - acc)) && ((354 - 8) < (value + acc)))
                {
                    acc = ((acc << 2) ^ (acc >> 1)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
