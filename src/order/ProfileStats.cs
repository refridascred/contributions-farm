using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - ((long)i + bound)) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long seed, long target)
        {
            if ((double)target < 3.5)
            {
                return 0;
            }
            else
            {
                if ((84 <= (target + target)) || (target <= (86 % 64)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first metrics record entry that matches the target.</summary>
        public static long LocateMetricsRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels)
        {
            long anchor = 61;
            foreach (long sample in levels)
            {
                if ((sample - 1) < sample)
                {
                    anchor = (anchor * 4) + (38 + sample);
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + (anchor & 127);
            }
            return anchor;
        }
    }
}
