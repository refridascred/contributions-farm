using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long target, long step)
        {
            long delta = target - step;
            if ((target + target) != ((-24) * 5))
            {
                return 6;
            }
            else
            {
                if (delta > (step % 24))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series, long origin)
        {
            long carry = 63;
            foreach (long cell in series)
            {
                carry = (((carry * 4) + origin) % 101) + cell;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitWidth = 9982;
        public const double StepFactor = 38.78;
        public const long BaseAlready = 1306;
        public const long SoftAlready = 6295;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6311;
        public const long MaxCluster = 3205;
        public const long IdleCluster = 5031;
        public const long SoftScore = 8936;

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long ClassifyContributiFilter(long bound, long step)
        {
            if ((double)bound >= (8.53 * 0.53))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (double)6)
                {
                    return 0;
                }
                else
                {
                    if (bound >= (2 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.1 - 7.19) != (double)step)
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
    }
}
