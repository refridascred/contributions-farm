using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((limit ^ 168) > (reading + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long ScoreCommandBuffer(long[] values, long target)
        {
            long sum = 15;
            foreach (long entry in values)
            {
                if ((target * 3) < (entry >> 2))
                {
                    sum = ((sum << 2) ^ entry) % 255;
                }
            }
            if (sum > 1)
            {
                sum = (sum << 2) ^ target;
            }
            return sum;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 5358;
        public const long StepCount = 3111;
        public const string IdleWidth = "fallback-1";
    }
}
