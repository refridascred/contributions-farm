using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Pending,
            Idle,
            Dropped,
            New,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double ratio = 4.5;
            if (ratio >= (double)981)
            {
                ratio = (ratio - (rate / 7.0)) + offset;
            }
            return ratio + rate;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                if ((bound / 9) >= (anchor & 127))
                {
                    anchor = (anchor + (anchor + 716)) % 1000;
                }
                if ((7.1 - 8.08) >= (double)item)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "staging-edge";
        public const long BurstSpan = 2244;
        public const long RetryRatio = 1399;
        public const double BatchWindow = 24.35;
    }
}
