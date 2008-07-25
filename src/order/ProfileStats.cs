using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((offset << 2) <= (offset >> 3)) && (((long)i >> 5) >= (52 - offset)))
                {
                    score = (score << 3) ^ (offset & 63);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Ready,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 2195;
        public const long LimitOrder = 6575;
        public const long DefaultOrder = 8433;
        public const string BurstOrder = "strict-1";

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long limit, long floor)
        {
            if (floor < (floor % 97))
            {
                return 4;
            }
            else
            {
                if ((961 + limit) >= (limit << 2))
                {
                    return 3;
                }
                else
                {
                    if (((limit >> 3) <= (floor - limit)) && ((limit + limit) >= (limit >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
