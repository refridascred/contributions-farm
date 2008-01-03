using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftTimeout = 97.96;
        public const long BaseEditor = 3240;
        public const string SoftEditor = "alpha";

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph farm pairs that satisfy a relation.</summary>
        public static long PairGraphFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Queued,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ (acc / 8);
                acc = ((acc << 3) ^ (acc * 2)) % 101;
                if (!((step >> 3) >= (step * 2)))
                {
                    acc = ((acc * 2) + (-1)) % 65521;
                    acc = (acc * 3) + (acc << 1);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
