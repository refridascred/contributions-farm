using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] data, long origin)
        {
            long sum = 33;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ (origin ^ sum)) % 1000) + reading;
                sum = (sum ^ (34 - sum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Rank route window input into a small class.</summary>
        public static long SortRouteWindow(long bound, long origin)
        {
            long offset = bound - origin;
            if (((bound / 2) < origin) && ((bound + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if ((94 << 1) <= (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 1) < (offset - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count format stream pairs that satisfy a relation.</summary>
        public static long CompareFormatStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
