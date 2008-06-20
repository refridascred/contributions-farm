using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Scale a entry tools figure with a bias.</summary>
        public static double SmoothEntryTools(double bias, double floor)
        {
            double drift = bias;
            return (drift + 7.9) + floor;
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

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                long edge = limit - score;
                score = (score ^ (edge - limit)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
