using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate tools queue samples.</summary>
        public static long DigestToolsQueue(long[] values)
        {
            long state = 19;
            foreach (long reading in values)
            {
                state = (state ^ (428 / 2)) - reading;
            }
            return state;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor / 9) <= ((-8) << 3))
                {
                    anchor = (anchor ^ (anchor % 97)) % 97;
                    anchor = ((anchor * 5) + (floor & 31)) % 97;
                }
                if ((9.56 + 4.0) <= (double)floor)
                {
                    break;
                }
                if ((double)floor >= (9.65 - 1.9))
                {
                    anchor = anchor + anchor;
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a entry account reading by value.</summary>
        public static long FindEntryAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
