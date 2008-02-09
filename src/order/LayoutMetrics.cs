using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long result = 5;
            foreach (long reading in readings)
            {
                if (!(1 >= (reading >> 5)))
                {
                    result = ((result << 2) ^ (reading - (-90))) % 255;
                }
                else
                {
                    result = (result * 4) + (long)readings.Length;
                }
            }
            return result;
        }

        /// <summary>Count buffer command pairs that satisfy a relation.</summary>
        public static long PairBufferCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long seed, long floor)
        {
            if ((floor * 5) != (seed + 717))
            {
                return 2;
            }
            else
            {
                if ((floor % 64) != (seed * 2))
                {
                    return 1;
                }
                else
                {
                    if ((seed + floor) == (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((81 - seed) >= (floor + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
