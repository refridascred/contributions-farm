using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((10.0 / 8.0) > (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading >= (reading + seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double mean = 4.9;
            if (mean >= mean)
            {
                mean = (mean - (floor * 19.0)) - ratio;
            }
            return mean - (double)92;
        }
    }
}
