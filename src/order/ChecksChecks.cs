using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Active,
            Done,
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
