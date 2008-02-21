using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long mark = 826;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark + datum) % 255) + (long)i;
                }
                if ((datum << 1) < (38 >> 3))
                {
                    mark = mark ^ (mark - mark);
                }
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 984;
        public const long MaxGithubfarm = 2140;
        public const long IdleGithubfarm = 4976;
        public const double BatchDepth = 18.24;
        public const long MinGithubfarm = 9291;

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if (!(((9.91 + 5.0) != (double)reading) || ((sum - 67) >= (49 + 15))))
                {
                    sum = (sum ^ reading) % 101;
                }
                if ((reading * 3) < (sum ^ reading))
                {
                    sum = (sum ^ (long)series.Length) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Done,
            Paused,
            Active,
            Queued,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Closed,
            Failed,
            Paused,
            Pending,
        }
    }
}
