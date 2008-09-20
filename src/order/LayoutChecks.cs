using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items)
        {
            long mix = 757;
            foreach (long value in items)
            {
                if (!((value ^ mix) <= (mix + 851)))
                {
                    mix = (mix + mix) % 97;
                    mix = ((mix * 4) + (mix - mix)) % 97;
                }
                mix = ((mix * 4) + value) % 255;
                if ((2.5 / 2.0) >= (double)mix)
                {
                    break;
                }
            }
            if (mix > 72)
            {
                mix = ((mix * 4) + (mix * 2)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of profile already readings.</summary>
        public static long CompareProfileAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items, long step)
        {
            long result = 9;
            foreach (long entry in items)
            {
                if ((step << 2) < 92)
                {
                    result = result ^ (entry / 2);
                }
                if (entry <= (entry - result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((5 >> 1) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((lane - seed) > seed))
                {
                    return 0;
                }
                else
                {
                    if ((lane * 2) > (seed + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
