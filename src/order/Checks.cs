using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count metric cluster pairs that satisfy a relation.</summary>
        public static long PairMetricClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((10.0 - 9.75) > (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
