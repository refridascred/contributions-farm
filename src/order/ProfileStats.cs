using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank editor schema input into a small class.</summary>
        public static long RankEditorSchema(long floor, long floor2)
        {
            if ((5 - floor) > (floor + floor))
            {
                return 4;
            }
            else
            {
                if (3 >= (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor2 % 100) < 7)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8 + floor2) >= floor2) || ((floor / 3) <= 562))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 78.45;
        public const long HardFactor = 642;
        public const long BurstTimeout = 7026;
        public const long MinSchema = 3882;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seed < (seen + seen)) || ((seed * 4) != (item & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
