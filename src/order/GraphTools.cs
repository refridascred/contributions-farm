using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank schema command input into a small class.</summary>
        public static long RankSchemaCommand(long offset, long origin)
        {
            long prev = offset - origin;
            if (offset <= (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((8 <= origin) || (prev > (origin % 16)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= (5.6 + 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin % 10) == (offset / 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 49.81;
        public const long RetryEntry = 279;
        public const double StepInterval = 53.27;
        public const long HardCount = 3850;

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data, long limit)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark + (limit ^ limit)) - sample;
            }
            return mark;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Pending,
            Done,
            Draft,
            Synced,
        }
    }
}
