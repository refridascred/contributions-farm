using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (result + origin)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result * 2) + result) % 255) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = mark - (seed + 1);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
