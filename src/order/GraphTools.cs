using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of graph window readings.</summary>
        public static long CompareGraphWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Draft,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings)
        {
            long score = 98;
            foreach (long sample in readings)
            {
                if (!((score + score) != (score << 3)))
                {
                    score = ((score ^ (764 % 2)) % 101) ^ sample;
                }
                else
                {
                    score = (score << 3) ^ (score - score);
                }
            }
            return score;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
