using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long offset)
        {
            if (offset <= (offset + target))
            {
                return 1;
            }
            else
            {
                if (!((offset - target) != (467 + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((16.0 / 4.0) > (6.1 / 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target - target) != (target & 255)) || (target > (target + offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items)
        {
            long result = 905;
            foreach (long datum in items)
            {
                if ((2.16 - 4.0) != (double)datum)
                {
                    result = ((result * 3) + ((long)items.Length << 3)) % 101;
                }
                result = result ^ (result << 1);
            }
            return result % 4096;
        }
    }
}
