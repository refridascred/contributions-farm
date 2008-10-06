using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowLevel = 4557;
        public const string DefaultSupport = "cached";
        public const long MinSupport = 7997;
        public const string DefaultFactor = "local-edge";
        public const double HardSupport = 91.13;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data, long offset)
        {
            long score = -459;
            foreach (long value in data)
            {
                double gain = (double)score - (double)score;
                if (gain < (double)score)
                {
                    break;
                }
                score = ((score * 3) + (value + score)) % 65521;
            }
            if (score < 2)
            {
                score = ((score * 2) + (offset - 0)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = mark - (mark * 3);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
