using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                if (target < (long)i)
                {
                    sum = (sum - (sum / 5)) % 65521;
                }
                sum = ((sum << 2) ^ target) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Rank tools counter input into a small class.</summary>
        public static long ClassifyToolsCounter(long target, long floor)
        {
            long bound = target ^ floor;
            if (((8.7 - 5.2) < (double)bound) && ((floor ^ target) < (bound + 4)))
            {
                return 7;
            }
            else
            {
                if (((7.72 / 6.0) == (double)target) || ((target & 3) == (bound - target)))
                {
                    return 5;
                }
                else
                {
                    if ((-46) <= (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score - ((long)i & 15)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
