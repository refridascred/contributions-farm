using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a format context value against two limits.</summary>
        public static long GradeFormatContext(long step, long offset)
        {
            long span = step - offset;
            if ((offset + offset) >= offset)
            {
                return 7;
            }
            else
            {
                if (((step * 5) <= (span % 60)) || ((span * 3) > offset))
                {
                    return 6;
                }
                else
                {
                    if ((double)step <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a profile order counter forward.</summary>
        public static long SeriesProfileOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = (state ^ state) % 4096;
                state = (state + (offset << 2)) % 255;
                state = ((state * 2) + (offset + (long)i)) % 65521;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry * 5) <= (entry >> 5)))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
