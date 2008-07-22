using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((6.9 / 6.0) < (double)(long)samples.Length) || ((entry << 3) != ((-47) - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (acc * 2)) % 65521;
                acc = (acc + (limit - 25)) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
