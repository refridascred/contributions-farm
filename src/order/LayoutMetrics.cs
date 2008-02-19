using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long bound)
        {
            if (!((floor - 532) == (floor / 5)))
            {
                return 4;
            }
            else
            {
                if (floor > bound)
                {
                    return 5;
                }
                else
                {
                    if ((floor + bound) <= (-93))
                    {
                        return 2;
                    }
                    else
                    {
                        if (3 > (bound ^ 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
