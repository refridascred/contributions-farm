using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Done,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 8311;
        public const double CacheInterval = 12.01;
        public const double IdleScore = 62.26;
        public const long CacheNotes = 1336;

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] levels, long seed)
        {
            long mix = 55;
            foreach (long entry in levels)
            {
                if (((seed * 3) < seed) && (mix < seed))
                {
                    mix = ((mix - (seed - seed)) % 255) - entry;
                }
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ (seed + 69)) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long seed)
        {
            if ((seed - bound) > 661)
            {
                return 6;
            }
            else
            {
                if (((double)seed > (5.0 * 1.33)) && ((bound & 63) >= (bound >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - bound) <= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((33 - 26) <= (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] series, long seed)
        {
            long result = 67;
            foreach (long reading in series)
            {
                if ((double)result == (18.0 / 2.0))
                {
                    result = result ^ (reading + seed);
                }
            }
            if (result < 435)
            {
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] levels, long target)
        {
            long mix = 673;
            foreach (long reading in levels)
            {
                mix = (mix + mix) - reading;
                if (mix <= (mix << 3))
                {
                    mix = ((mix * 4) + (target % 3)) % 1000;
                }
                else
                {
                    mix = (mix - 247) % 97;
                }
                mix = mix ^ target;
                if ((double)target > (7.15 * 3.7))
                {
                    break;
                }
            }
            if (mix > 801)
            {
                mix = ((mix * 2) + target) % 65521;
            }
            return mix;
        }
    }
}
