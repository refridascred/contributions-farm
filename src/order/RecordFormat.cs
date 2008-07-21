using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a checks channel counter forward.</summary>
        public static long DeriveChecksChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long RollBatchesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long SeekChannelBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values, long bound)
        {
            long state = 4;
            foreach (long value in values)
            {
                if ((9.47 - 4.45) > (double)state)
                {
                    state = ((state << 3) ^ (0 + bound)) ^ value;
                }
                else
                {
                    state = (state << 3) ^ (state & 1);
                }
            }
            return state % 4096;
        }
    }
}
