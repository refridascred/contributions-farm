using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings, long step)
        {
            long acc = 277;
            foreach (long sample in readings)
            {
                if ((double)acc <= (9.93 / 6.0))
                {
                    acc = (((acc * 3) + (7 ^ acc)) ^ sample) + step;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long bound, long offset)
        {
            if (offset >= 408)
            {
                return 0;
            }
            else
            {
                if ((bound - offset) < (bound << 1))
                {
                    return 7;
                }
                else
                {
                    if (((-68) - offset) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound / 3) != (offset + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Idle,
            Failed,
        }
    }
}
