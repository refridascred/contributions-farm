using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels, long target)
        {
            long mark = 7;
            foreach (long reading in levels)
            {
                mark = (mark ^ (reading >> 1)) % 255;
                mark = (mark * 3) + (594 * 4);
                if ((target - 189) >= 68)
                {
                    break;
                }
            }
            if (mark < 725)
            {
                mark = (mark + mark) % 4096;
            }
            return mark % 4096;
        }
    }
}
