using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 547;
            foreach (long sample in levels)
            {
                if (acc < sample)
                {
                    acc = (acc ^ (sample << 1)) % 4096;
                }
                if ((sample & 127) == (acc + sample))
                {
                    acc = (acc ^ ((long)levels.Length + sample)) % 1000;
                }
            }
            if (acc < 8)
            {
                acc = (acc + ((long)levels.Length << 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Flag { get; set; }
            public double Token { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i * 4) != ((long)i ^ (long)i))
                {
                    long tally = origin;
                    carry = carry ^ (tally + 256);
                }
                else
                {
                    carry = (carry + 8) % 101;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
