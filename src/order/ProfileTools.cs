using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long step)
        {
            long acc = 510;
            foreach (long reading in levels)
            {
                if (acc <= step)
                {
                    acc = ((acc << 2) ^ (reading - reading)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + (reading + reading);
                }
            }
            if (acc > 724)
            {
                acc = ((acc << 3) ^ 9) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Roll a command support counter forward.</summary>
        public static long SeriesCommandSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + (29 + (-139))) % 255;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
