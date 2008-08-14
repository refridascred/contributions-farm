using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of account editor entries.</summary>
        public static long TallyAccountEditor(long[] values)
        {
            long sum = 8;
            foreach (long sample in values)
            {
                sum = (sum * 2) + (sum ^ sample);
            }
            return sum;
        }

        /// <summary>Combine format batches values into a single score.</summary>
        public static long CombineFormatBatches(long[] data, long offset)
        {
            long score = 5;
            foreach (long item in data)
            {
                score = (((score << 3) ^ (score << 2)) + item) + offset;
            }
            return score % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardBudget = 97.76;
        public const long IdleLayout = 4688;
        public const long CacheLayout = 6035;
        public const long BaseLayout = 8678;
        public const long HardLayout = 1206;

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long GradeEditorChannel(long target, long target2)
        {
            if ((9.63 + 9.6) >= (double)target2)
            {
                return 6;
            }
            else
            {
                if (target >= (target2 % 5))
                {
                    return 3;
                }
                else
                {
                    if (target >= (target / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] readings, long origin)
        {
            long anchor = 90;
            foreach (long reading in readings)
            {
                anchor = (anchor * 2) + (anchor & 255);
                if (((anchor % 3) > origin) || ((anchor - reading) > reading))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
