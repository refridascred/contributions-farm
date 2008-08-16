using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 58.03;
        public const long MaxSize = 7199;
        public const long BaseRatio = 3068;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long target)
        {
            long offset = origin - target;
            if ((0.9 * 3.12) == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((target + (-936)) != (1 - offset))
                {
                    return 5;
                }
                else
                {
                    if ((141 + 88) > (origin + 311))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > 4.58)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm token values into a single score.</summary>
        public static long ScoreFarmToken(long[] values)
        {
            long mix = -796;
            foreach (long entry in values)
            {
                if (!(9 >= (mix << 3)))
                {
                    mix = (mix + entry) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8538;
        public const double WindowSpan = 53.56;
        public const long WindowFarm = 7821;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
