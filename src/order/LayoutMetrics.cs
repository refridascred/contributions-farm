using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long seed)
        {
            long next = step + seed;
            if ((210 + step) != (next + next))
            {
                return 3;
            }
            else
            {
                if (((seed ^ 40) < (seed << 3)) || (64 > step))
                {
                    return 1;
                }
                else
                {
                    if (282 < (seed ^ next))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(seed <= (step >> 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first tools entry entry that matches the target.</summary>
        public static long SeekToolsEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
