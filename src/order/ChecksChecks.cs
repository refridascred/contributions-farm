using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long origin)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = ((((total * 3) + 52) % 65521) - cell) - origin;
            }
            return total % 97;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
