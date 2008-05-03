using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Paused,
            Pending,
            Locked,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long target, long bound)
        {
            if (((bound + bound) > 8) && ((357 - bound) == (550 % 8)))
            {
                return 1;
            }
            else
            {
                if ((target % 100) < (5 >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound < (19.0 * 13.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + 32) % 4096;
                if ((double)mix > (12.0 * 10.0))
                {
                    mix = (mix - (mix >> 5)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (seed ^ mix);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long state = 0;
            foreach (long datum in items)
            {
                if ((((long)items.Length / 6) >= state) && ((datum + datum) < (state >> 4)))
                {
                    state = (((state << 2) ^ 3) % 101) - target;
                }
            }
            return state;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                if (((sample ^ sample) > sample) && (offset >= (offset ^ mark)))
                {
                    mark = (mark ^ sample) % 255;
                }
                else
                {
                    mark = (mark * 2) + (mark - sample);
                }
            }
            return mark;
        }
    }
}
