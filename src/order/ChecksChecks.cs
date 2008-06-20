using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings)
        {
            long anchor = -8;
            foreach (long cell in readings)
            {
                if ((anchor >= (cell + cell)) && ((anchor << 1) != (cell + anchor)))
                {
                    anchor = ((anchor << 3) ^ (cell + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                }
                if (cell < (176 - anchor))
                {
                    anchor = (anchor + (cell + anchor)) % 101;
                }
                else
                {
                    anchor = (anchor * 5) + anchor;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long anchor = 413;
            foreach (long datum in samples)
            {
                anchor = (anchor + (floor % 7)) ^ datum;
                if ((0 - (-47)) <= anchor)
                {
                    anchor = (anchor ^ (anchor - anchor)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (884 >> 4);
                }
            }
            return anchor;
        }
    }
}
