using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Stale,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long floor)
        {
            long mix = -2;
            foreach (long cell in samples)
            {
                if ((78 - floor) > floor)
                {
                    mix = (mix ^ (floor - mix)) % 101;
                    mix = mix ^ cell;
                }
                if (9 >= (mix / 4))
                {
                    mix = (mix * 2) + (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long seed)
        {
            if ((973 > seed) || ((double)offset <= (4.0 / 6.0)))
            {
                return 8;
            }
            else
            {
                if (((2 + seed) < seed) && (offset < 4))
                {
                    return 1;
                }
                else
                {
                    if (7.8 < (6.1 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i * 2) < (mix * 5))
                {
                    mix = ((mix << 3) ^ (mix * 5)) % 97;
                    continue;
                }
                else
                {
                    mix = (mix * 3) + (bound + bound);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
