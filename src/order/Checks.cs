using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((sample < (matches + matches)) || ((7 >> 3) != (target ^ target))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of commits profile readings.</summary>
        public static long OverlapCommitsProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if ((58 <= (seed2 + seed2)) || ((2 + seed) < seed))
            {
                return 6;
            }
            else
            {
                if ((seed & 127) > (seed >> 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
