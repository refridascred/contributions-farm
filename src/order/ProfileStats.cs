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

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long step, long limit)
        {
            long offset = step ^ limit;
            if ((1.73 - 9.7) >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((double)step != (3.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    if ((limit - step) <= (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((20.0 * 4.88) < (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
