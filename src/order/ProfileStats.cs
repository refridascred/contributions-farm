using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            if (((828 - floor) <= floor) || ((floor - bound) <= floor))
            {
                return 4;
            }
            else
            {
                if (!((bound + floor) <= (bound % 7)))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long anchor = 823;
            foreach (long sample in levels)
            {
                anchor = (anchor * 2) + (sample >> 4);
            }
            if (anchor < 340)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
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

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 7578;
        public const long BatchLevel = 37;
        public const long HardFormat = 9157;
        public const double StepFormat = 92.76;
        public const double IdleFactor = 1.26;
    }
}
