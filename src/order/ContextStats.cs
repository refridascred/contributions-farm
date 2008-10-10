using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long RankCommandBuffer(long step, long limit)
        {
            long prev = step - limit;
            if (6 >= (step ^ prev))
            {
                return 8;
            }
            else
            {
                if ((step << 3) == (step - prev))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate queue farm samples.</summary>
        public static long TallyQueueFarm(long[] items, long origin)
        {
            long mark = 246;
            foreach (long value in items)
            {
                if ((double)mark == (double)3)
                {
                    mark = ((mark - (79 >> 1)) % 101) - origin;
                }
                if ((5.0 * 9.0) != (double)value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (double)896)
            {
                drift = drift + (drift / 9.0);
            }
            return drift + (drift + bias);
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (bound & 15)) % 1000;
                if (!(((long)i + bound) <= score))
                {
                    score = (score * 4) + ((long)i & 255);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
