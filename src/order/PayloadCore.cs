using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long offset, long floor)
        {
            if ((offset & 31) < (501 << 2))
            {
                return 3;
            }
            else
            {
                if ((5 >> 3) >= (floor - 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchInterval = 77.66;
        public const long SoftCount = 9112;
        public const double MaxCount = 26.45;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
