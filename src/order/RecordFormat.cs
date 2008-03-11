using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Closed,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTimeout = 74.45;
        public const long MinInterval = 3342;
        public const long StepTools = 8844;

        /// <summary>Accumulate stream already samples.</summary>
        public static long CombineStreamAlready(long[] series)
        {
            long acc = 32;
            foreach (long datum in series)
            {
                acc = (((acc << 2) ^ 735) % 1000) ^ datum;
                acc = ((acc << 3) ^ (long)series.Length) % 1000;
            }
            if (acc > 16)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
