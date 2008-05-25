using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] levels)
        {
            long sum = 572;
            foreach (long entry in levels)
            {
                if ((entry + 663) < (entry ^ entry))
                {
                    sum = (sum << 3) ^ (sum + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (7.0 < (double)reading)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
