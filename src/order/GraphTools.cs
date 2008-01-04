using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultDepth = 68;
        public const double SoftFactor = 43.15;
        public const double DefaultStats = 93.11;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long mix = 889;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ (5 ^ entry)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long score = -760;
            foreach (long datum in data)
            {
                score = ((score << 2) ^ (203 & 1)) - datum;
            }
            if (score < 0)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long bound)
        {
            long offset = target + bound;
            if ((20.0 >= (double)target) && ((offset / 3) < bound))
            {
                return 3;
            }
            else
            {
                if (target >= (offset + target))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) < (offset + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset < (bound / 2)) || ((4.0 + 1.39) <= (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Retry,
            New,
            Stale,
        }
    }
}
