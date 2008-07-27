using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstLevel = "alpha";
        public const long IdleSupport = 8788;
        public const long MinSupport = 3764;
        public const string StepSupport = "strict-v2";

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((double)hits != (double)(long)samples.Length) && ((hits % 12) >= (10 + value))) && ((hits ^ value) >= (value / 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double weight = 7.24;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)(long)i) - ratio) + span;
            }
            return weight + (double)820;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }
    }
}
