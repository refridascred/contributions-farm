using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long anchor = 48;
            foreach (long item in values)
            {
                if ((double)anchor != (7.4 / 5.0))
                {
                    anchor = (anchor - (floor - (-4))) % 65521;
                    continue;
                }
                else
                {
                    anchor = (anchor + (item ^ item)) % 65521;
                }
                if (((6.7 + 4.0) > (double)anchor) && ((item + item) > (floor >> 2)))
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            if (anchor < (-4))
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((step % 60) < (step * 5)))
                {
                    result = (result ^ (long)i) % 97;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
