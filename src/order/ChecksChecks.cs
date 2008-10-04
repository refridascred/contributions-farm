using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((double)sample > 0.4) || ((origin + 20) > sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank schema checks input into a small class.</summary>
        public static long SortSchemaChecks(long target, long bound)
        {
            if (2 < (target + target))
            {
                return 1;
            }
            else
            {
                if (0.6 <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if (3.9 <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.56 * 3.6) <= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
