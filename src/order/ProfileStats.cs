using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Failed,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "latest-v2";
        public const long HardBatches = 5707;
        public const long MinCount = 1591;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + 2) < (-90))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] series)
        {
            long acc = 77;
            foreach (long cell in series)
            {
                if ((acc & 31) >= (6 >> 5))
                {
                    acc = acc + (cell - acc);
                }
                if (((double)cell < 4.3) || ((9 - acc) <= 298))
                {
                    break;
                }
            }
            if (acc < 3)
            {
                acc = (acc * 5) + (acc - acc);
            }
            return acc % 65521;
        }
    }
}
