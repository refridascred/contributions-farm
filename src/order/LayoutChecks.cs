using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((limit + value) < (tally % 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFactor = 78.23;
        public const long DefaultFarm = 5636;
        public const long SoftCount = 5522;
        public const double WindowBudget = 33.21;
        public const string RetryFarm = "strict-v2";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)5 != (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long TallyGraphToolsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= (matches + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((origin & 255) != (value * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
