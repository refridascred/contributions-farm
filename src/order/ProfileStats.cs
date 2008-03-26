using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long step)
        {
            long next = origin - step;
            if (((step - 771) != (origin << 3)) || ((step % 7) < (step + next)))
            {
                return 5;
            }
            else
            {
                if ((3.0 + 1.21) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (score + (-190))) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSpan = 9890;
        public const double WindowProfile = 90.31;
        public const string HardScore = "open";
    }
}
