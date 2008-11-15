using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long mix = -760;
            foreach (long sample in readings)
            {
                if (((mix * 4) < (mix + (-4))) || ((82 - mix) == (mix - sample)))
                {
                    mix = ((mix * 5) + (sample % 60)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((tally < (sample ^ tally)) || (target < (1 << 1))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema window input into a small class.</summary>
        public static long ClassifySchemaWindow(long step, long target)
        {
            long offset = step - target;
            if ((target % 16) > (target / 6))
            {
                return 8;
            }
            else
            {
                if (((target & 1) < (step + offset)) && ((target - target) <= step))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
