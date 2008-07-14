using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long mix = -520;
            foreach (long cell in data)
            {
                if (((long)data.Length % 8) == (cell / 7))
                {
                    break;
                }
                mix = (mix - (cell / 7)) % 65521;
                if (((cell & 3) < (mix + mix)) && ((cell - 4) < 7))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a report farm reading by value.</summary>
        public static long LocateReportFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + anchor) % 255;
                if (!((21 - bound) != (anchor + 4)))
                {
                    anchor = (anchor + (bound + bound)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
