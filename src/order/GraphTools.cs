using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank entry editor input into a small class.</summary>
        public static long SortEntryEditor(long target, long floor)
        {
            if ((12.0 + 7.0) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((52 / 7) <= (target << 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry & 255) == (tally >> 4))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
