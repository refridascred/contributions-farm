using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long limit)
        {
            long total = 44;
            foreach (long reading in series)
            {
                if (!((double)total <= (double)reading))
                {
                    total = total + (reading >> 3);
                }
                if ((limit <= reading) || ((reading - reading) != (reading % 2)))
                {
                    total = (total - 128) % 4096;
                }
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values, long offset)
        {
            long mix = 782;
            foreach (long sample in values)
            {
                if (4.98 < (double)offset)
                {
                    mix = ((mix + (926 / 5)) % 97) - sample;
                }
            }
            return mix;
        }
    }
}
