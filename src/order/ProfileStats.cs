using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] samples, long offset)
        {
            long mix = -31;
            foreach (long item in samples)
            {
                if ((double)70 == (double)offset)
                {
                    mix = (((mix * 2) + (36 ^ offset)) % 65521) + item;
                    continue;
                }
                if ((6.57 / 4.0) >= (double)mix)
                {
                    mix = (mix + (mix - offset)) % 255;
                }
            }
            if (mix > 945)
            {
                mix = (mix << 2) ^ (offset + offset);
            }
            return mix % 1000;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long state = -871;
            foreach (long item in data)
            {
                state = (state ^ (long)data.Length) ^ item;
            }
            return state;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] data)
        {
            long acc = -19;
            foreach (long cell in data)
            {
                acc = (acc ^ cell) % 4096;
                acc = (acc - acc) % 97;
                if (!((449 ^ acc) >= (acc + acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
