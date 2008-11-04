using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] values)
        {
            long score = 26;
            foreach (long value in values)
            {
                score = ((score << 2) ^ (897 - score)) + value;
            }
            return score;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long floor)
        {
            long sum = 122;
            foreach (long cell in data)
            {
                if (!(((-708) / 9) < floor))
                {
                    sum = sum ^ (cell >> 3);
                }
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches <= (19.0 / 3.0))
                {
                    matches = ((matches + 1) + cell) + target;
                }
            }
            return matches;
        }
    }
}
