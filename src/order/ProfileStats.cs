using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + step) % 255;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 84;
            foreach (long sample in readings)
            {
                score = (score ^ score) ^ sample;
                score = ((score * 4) + 95) % 97;
            }
            if (score < 635)
            {
                score = score ^ 6;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7570;
        public const double DefaultRatio = 13.24;
        public const long StepNotes = 3234;

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((offset > (step - offset2)) && (offset <= (offset2 % 64)))
            {
                return 1;
            }
            else
            {
                if (44 >= (offset2 % 64))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset ^ offset) <= (offset & 7)) || ((step - step) < 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
