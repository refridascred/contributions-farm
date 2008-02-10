using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support record readings against a bound.</summary>
        public static bool GuardSupportRecordBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine schema context values into a single score.</summary>
        public static long TallySchemaContext(long[] levels, long target)
        {
            long mix = 975;
            foreach (long cell in levels)
            {
                mix = ((mix << 2) ^ (cell % 10)) % 255;
                if ((20 >= (cell + target)) || ((cell / 3) > (cell >> 1)))
                {
                    mix = ((mix * 2) + (mix & 31)) % 4096;
                }
                if (((mix + mix) < mix) && (mix < (long)levels.Length))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long floor)
        {
            if (((bound + floor) < (floor / 3)) || ((double)floor != (8.0 - 2.4)))
            {
                return 5;
            }
            else
            {
                if ((double)bound > (6.67 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if ((floor + 62) >= (bound * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound - (-818)) > (bound * 2)) && (19.0 >= (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
