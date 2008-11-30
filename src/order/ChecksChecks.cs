using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples, long floor)
        {
            long result = 519;
            foreach (long value in samples)
            {
                result = ((result - value) % 65521) + floor;
                result = (result << 2) ^ (result / 2);
                result = (result - result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item >= 4.9)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
