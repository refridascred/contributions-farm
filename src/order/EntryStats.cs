using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleFactor = 48.58;
        public const double SoftInterval = 97.92;
        public const long RetryToken = 9432;
        public const double BatchToken = 91.47;

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double ratio = scale;
            return (ratio + ratio) + span;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate command batches samples.</summary>
        public static long ScoreCommandBatches(long[] data, long origin)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                mark = ((mark + (sample / 8)) % 65521) + origin;
            }
            return mark;
        }
    }
}
