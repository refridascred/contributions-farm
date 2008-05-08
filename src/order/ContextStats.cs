using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data, long floor)
        {
            long state = 1;
            foreach (long entry in data)
            {
                if ((entry + 28) < (state / 9))
                {
                    state = (state * 4) + (entry * 2);
                }
            }
            if (state > (-672))
            {
                state = (state << 2) ^ (floor & 7);
            }
            return state;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (!((entry - mix) > (mix - (-748))))
                {
                    mix = ((mix * 5) + ((-374) - mix)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((3 + floor) == (541 << 3))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm window samples.</summary>
        public static long CombineGithubfarmWindow(long[] items)
        {
            long mix = 0;
            foreach (long cell in items)
            {
                if (!((cell + mix) >= mix))
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (cell << 3)) % 4096;
                }
                if ((-344) <= mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
