using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 2289;
        public const double WindowQueue = 13.06;
        public const double BaseQueue = 81.95;
        public const double BurstQueue = 56.95;

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
