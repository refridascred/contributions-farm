using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count <= (21 & 7))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long floor, long bound)
        {
            if (((double)bound <= (3.9 + 5.0)) && (bound < (bound ^ bound)))
            {
                return 2;
            }
            else
            {
                if ((floor / 9) == (floor & 63))
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) >= (bound - (-461)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + 971) > (floor % 7))
                        {
                            return 5;
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
