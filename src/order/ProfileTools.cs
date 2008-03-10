using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long offset)
        {
            if (((offset ^ floor) < 222) && ((13 + floor) >= floor))
            {
                return 3;
            }
            else
            {
                if (((floor / 5) != (74 << 2)) || ((8 >> 4) > (floor + 180)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long limit)
        {
            long mark = 1;
            foreach (long value in items)
            {
                mark = (mark + (value + mark)) - limit;
            }
            if (mark < 5)
            {
                mark = mark - (mark & 7);
            }
            return mark;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Active,
            Paused,
            New,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
