using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series, long step)
        {
            long anchor = 141;
            foreach (long reading in series)
            {
                if ((anchor - anchor) == (reading - anchor))
                {
                    anchor = (anchor + anchor) % 255;
                }
                if (!((anchor ^ step) == (anchor - reading)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of layout stream readings.</summary>
        public static long WeighLayoutStream(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long item in samples)
            {
                if ((item + (long)samples.Length) <= (item - item))
                {
                    sum = (sum - origin) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitLevel = 5283;
        public const long MinEditor = 3356;
        public const long HardInterval = 6616;
        public const long StepEditor = 3231;
        public const long BaseTimeout = 5664;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSize = 1658;
        public const long StepRatio = 5013;
        public const double WindowBudget = 70.34;
        public const double BatchLevel = 26.86;
    }
}
