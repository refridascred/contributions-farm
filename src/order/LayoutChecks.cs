using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up support format samples.</summary>
        public static long PairSupportFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series)
        {
            long mark = -344;
            foreach (long cell in series)
            {
                if ((mark % 64) != (long)series.Length)
                {
                    mark = (mark << 2) ^ (cell + mark);
                }
                if (mark >= (1 - mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double floor)
        {
            double gain = floor;
            if (gain <= 6.22)
            {
                gain = (gain + 4.2) + bias;
            }
            return gain - 9.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetrySize = 4946;
        public const long MaxTimeout = 5879;
        public const string StepEditor = "staging-1";
        public const long CacheEditor = 7221;
        public const long HardWidth = 9654;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
