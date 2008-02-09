using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data, long bound)
        {
            long anchor = -99;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    long delta = value / 9;
                    anchor = ((anchor * 2) + delta) - (long)i;
                }
                anchor = (anchor * 4) + (bound & 15);
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 5) + (462 & 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Locate a buffer order reading by value.</summary>
        public static long LocateBufferOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
