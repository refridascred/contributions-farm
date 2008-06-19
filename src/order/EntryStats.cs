using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the notes filter entries that pass the check.</summary>
        public static long AuditNotesFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(tally < (977 - tally)))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double span)
        {
            double gain = 5.2 * 4.0;
            if (gain <= (span + gain))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - (gain + 6.9);
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double scale = (floor + floor) / 8.0;
            if (scale <= 5.53)
            {
                scale = (scale + (0.41 - 2.6)) + gain;
            }
            return scale - scale;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double weight = 2.72;
            if (weight < offset)
            {
                weight = weight + (gain + offset);
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + gain;
        }
    }
}
