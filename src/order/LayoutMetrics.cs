using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a entry batches pair into a bucket.</summary>
        public static long GradeEntryBatches(long offset, long floor)
        {
            if (!(floor >= (offset >> 3)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset - offset))
                {
                    return 6;
                }
                else
                {
                    if ((floor % 5) > (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
