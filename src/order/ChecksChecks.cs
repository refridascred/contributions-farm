using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items, long floor)
        {
            long acc = 30;
            foreach (long entry in items)
            {
                if ((acc - acc) >= (470 & 7))
                {
                    acc = (((acc ^ (238 / 5)) % 1000) + entry) - floor;
                }
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
