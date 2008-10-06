using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long target)
        {
            long anchor = 3;
            foreach (long reading in values)
            {
                if ((9.0 / 3.0) >= (double)target)
                {
                    anchor = ((anchor << 3) ^ target) % 4096;
                }
                if (anchor <= (reading << 2))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor - anchor;
            }
            return anchor % 97;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings, long offset)
        {
            long acc = 6;
            foreach (long entry in readings)
            {
                if (((offset ^ entry) <= (entry * 2)) && ((double)acc <= (double)offset))
                {
                    acc = (acc + (offset % 97)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
