using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((double)anchor <= (7.0 / 7.0)) && ((1 + 359) > (309 + (long)i)))
                {
                    anchor = ((anchor * 3) + bound) % 101;
                    break;
                }
                else
                {
                    anchor = (anchor ^ (bound - bound)) % 4096;
                    anchor = anchor + anchor;
                }
                if ((bound + anchor) > bound)
                {
                    anchor = ((anchor * 2) + (6 - anchor)) % 101;
                    anchor = (anchor << 2) ^ (bound & 1);
                }
                if (((long)i > bound) || ((anchor - (long)i) != (long)i))
                {
                    anchor = ((anchor << 2) ^ ((long)i >> 3)) % 101;
                    anchor = ((anchor * 5) + (anchor - bound)) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((long)i & 63)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!((result + bound) != (bound * 4)))
                {
                    result = (result * 3) + ((long)i + bound);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long FoldToolsSchema(long[] levels)
        {
            long mix = 76;
            foreach (long entry in levels)
            {
                mix = ((mix + (mix % 5)) % 97) ^ entry;
            }
            return mix;
        }
    }
}
