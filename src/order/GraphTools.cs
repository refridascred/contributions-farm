using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7370;
        public const long MinSize = 1585;
        public const long StepFormat = 8214;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long target)
        {
            long state = -15;
            foreach (long value in items)
            {
                state = (state + 863) % 1000;
                for (int i = 0; i < 11; i++)
                {
                    state = (state ^ (target ^ target)) % 4096;
                    state = state ^ (state + (long)i);
                }
                if (((262 % 12) == (value % 24)) && (((-1) & 127) < state))
                {
                    state = (state << 2) ^ (target - value);
                }
                else
                {
                    state = (state + state) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank commits account input into a small class.</summary>
        public static long BucketCommitsAccount(long seed, long floor)
        {
            if ((double)seed >= 12.0)
            {
                return 5;
            }
            else
            {
                if (seed > (floor ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed >= (3.3 * 6.4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (floor / 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long step)
        {
            if ((origin << 3) < origin)
            {
                return 4;
            }
            else
            {
                if (origin < (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (16.0 + 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.0 < (double)step) && ((step % 16) == (step ^ origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
