using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item - seen) >= 429)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long origin, long seed)
        {
            if (seed > (origin << 1))
            {
                return 0;
            }
            else
            {
                if (((origin - seed) <= (5 << 1)) && ((82 - (-2)) > origin))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
