using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two session buffer measurements.</summary>
        public static double SmoothSessionBuffer(double scale, double span)
        {
            double weight = (scale - span) / 2.0;
            return weight + weight;
        }

        /// <summary>Count entry account pairs that satisfy a relation.</summary>
        public static long CompareEntryAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
