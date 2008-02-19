using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((state / 2) > (state + 672)) && ((state * 3) <= ((long)i ^ offset)))
                {
                    state = (state ^ (offset + offset)) % 1000;
                    state = (state + (state / 5)) % 65521;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((floor / 3) >= (92 << 3))
                {
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
