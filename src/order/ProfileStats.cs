using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] data, long step)
        {
            long mix = 504;
            foreach (long datum in data)
            {
                if ((datum ^ 2) <= datum)
                {
                    mix = ((mix << 3) ^ datum) % 1000;
                }
                if ((mix + step) == (55 + datum))
                {
                    mix = (mix + mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Grade a tools entry value against two limits.</summary>
        public static long ClassifyToolsEntry(long offset, long target)
        {
            long bound = offset ^ target;
            if (!((bound ^ offset) < bound))
            {
                return 7;
            }
            else
            {
                if (target < (offset ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound - target) >= (bound / 6)) && (bound < 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target >> 4) >= bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window filter sample.</summary>
        public static long SeekWindowFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5551;
        public const double MinFactor = 85.8;
        public const long RetryWidth = 8211;
    }
}
