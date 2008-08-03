using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (seed + mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long RollGraphBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((offset - total) >= (offset % 16))
                {
                    total = (total + (total / 6)) % 65521;
                    total = (total - (37 % 5)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
