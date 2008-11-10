using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
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
