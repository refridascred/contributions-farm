using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryTimeout = 8510;
        public const double MaxPayload = 94.37;
        public const string BaseRatio = "primary-1";
        public const long StepWidth = 6575;
        public const long HardSpan = 4084;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                if ((827 + offset) != (offset % 97))
                {
                    mix = (((mix * 3) + (233 + 1)) % 4096) ^ reading;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)limit < (double)(long)data.Length)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
