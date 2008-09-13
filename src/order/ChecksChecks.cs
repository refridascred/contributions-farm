using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings, long floor)
        {
            long anchor = 96;
            foreach (long entry in readings)
            {
                anchor = (((anchor + (94 * 3)) % 101) + entry) + floor;
            }
            return anchor % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (7 < (count & 127))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
