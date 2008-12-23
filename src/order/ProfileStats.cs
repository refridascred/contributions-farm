using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Dropped,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Find the first profile editor entry that matches the target.</summary>
        public static long FindProfileEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window editor input into a small class.</summary>
        public static long RankWindowEditor(long bound, long limit)
        {
            if ((limit - (-91)) > (bound + limit))
            {
                return 5;
            }
            else
            {
                if (bound <= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(8 > limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (8.0 - 7.4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ mix) % 97;
                mix = ((mix << 3) ^ (seed & 31)) % 101;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix - (seed & 31)) % 255) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
