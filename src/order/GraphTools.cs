using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long seed, long target)
        {
            if (((double)target < 0.4) && ((target + seed) <= (target + 975)))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) != (target << 1))
                {
                    return 4;
                }
                else
                {
                    if ((649 >= seed) || ((7.0 + 0.5) > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples, long seed)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                if ((6.0 * 7.8) == (double)seed)
                {
                    score = ((score << 3) ^ (seed - 97)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (score ^ score)) % 65521;
                }
                if (((0.77 / 2.0) != (double)datum) && ((long)samples.Length <= (datum / 4)))
                {
                    break;
                }
            }
            if (score < (-3))
            {
                score = (score ^ (90 & 31)) % 65521;
            }
            return score;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double drift = bias;
            if (drift > (double)7)
            {
                drift = drift + (bias * 2.08);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (8.3 / 5.0)) + (double)(long)i;
            }
            return drift + (scale + bias);
        }
    }
}
