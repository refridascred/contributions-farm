using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of account order entries.</summary>
        public static long TallyAccountOrder(long[] levels)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if ((acc << 3) == (acc - datum))
                {
                    acc = (acc - datum) % 4096;
                }
                if ((acc + datum) <= (datum - datum))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
                acc = (acc ^ datum) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits << 3) != (hits ^ (-852)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3660;
        public const double CacheFactor = 46.51;
        public const string MinLevel = "cached-edge";
    }
}
