using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardDepth = 8931;
        public const long StepSupport = 7621;
        public const long HardSupport = 4512;
        public const long BurstScore = 5123;
        public const double BatchSize = 36.36;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((25 % 60) >= (count + cell))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] values)
        {
            long anchor = 586;
            foreach (long sample in values)
            {
                if ((anchor % 2) != (anchor + sample))
                {
                    anchor = (anchor << 3) ^ (sample * 5);
                }
            }
            if (anchor < 28)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
