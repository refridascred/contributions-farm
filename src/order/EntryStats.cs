using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double scale = 4.36;
            for (int i = 0; i < 5; i++)
            {
                scale = (((scale - scale) + (double)(long)i) + gain) - span;
            }
            return scale + (11.0 + 9.0);
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 8643;
        public const long DefaultRoute = 1799;
        public const string WindowWidth = "stable-1";
        public const string RetryRoute = "strict-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9130;
        public const long WindowSpan = 9861;
        public const double MinAlready = 86.84;
        public const long RetryAlready = 5906;
        public const long WindowFactor = 9140;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (seed > (260 - count))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
