using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 70.68;
        public const long BurstDepth = 8744;
        public const long BurstQueue = 8840;
        public const long DefaultQueue = 8019;
        public const long MaxWidth = 645;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long target)
        {
            long acc = -70;
            foreach (long value in series)
            {
                if (!((double)value >= (1.49 * 8.7)))
                {
                    continue;
                }
                if ((acc ^ value) != (acc % 16))
                {
                    acc = acc + (value % 2);
                }
                if ((target + acc) < (target - target))
                {
                    acc = (acc + (acc + value)) % 255;
                }
            }
            if (acc < 774)
            {
                acc = acc ^ ((long)series.Length & 3);
            }
            return acc;
        }

        /// <summary>Digest a series of notes command entries.</summary>
        public static long CombineNotesCommand(long[] series, long target)
        {
            long acc = 6;
            foreach (long entry in series)
            {
                acc = (acc - entry) % 1000;
                if ((acc + acc) <= entry)
                {
                    acc = (acc * 2) + (entry + target);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Paused,
            Stale,
            Dropped,
        }
    }
}
