using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings, long floor)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc ^ (item & 63)) % 255) + (long)i;
                }
                if ((acc << 1) > 87)
                {
                    acc = acc - (410 * 5);
                }
                else
                {
                    acc = (acc * 5) + floor;
                }
            }
            return acc % 65521;
        }
    }
}
