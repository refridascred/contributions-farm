using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (score % 7)) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long mix = 5;
            foreach (long reading in samples)
            {
                if ((827 + offset) != (offset % 97))
                {
                    mix = (((mix * 3) + (233 + 1)) % 4096) ^ reading;
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total << 2) ^ (floor % 64);
                total = total ^ (total << 3);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank payload cluster input into a small class.</summary>
        public static long RankPayloadCluster(long step, long step2)
        {
            long span = step - step2;
            if ((31 * 3) >= step)
            {
                return 8;
            }
            else
            {
                if ((span - step2) <= (-341))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
