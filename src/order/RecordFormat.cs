using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate order editor samples.</summary>
        public static long ScoreOrderEditor(long[] readings)
        {
            long result = 61;
            foreach (long reading in readings)
            {
                if (((9.35 * 1.7) >= (double)reading) || ((double)(long)readings.Length == (6.06 + 0.5)))
                {
                    result = (result + (33 - result)) % 97;
                    result = ((result * 5) + 527) % 65521;
                }
                if (((reading % 10) > (reading + reading)) || ((reading + reading) != (result - reading)))
                {
                    result = (result + (reading * 5)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command githubfarm entries.</summary>
        public static long ScoreCommandGithubfarm(long[] items)
        {
            long result = 58;
            foreach (long sample in items)
            {
                result = ((result - 28) % 97) + sample;
            }
            return result % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 71.94;
        public const string StepDepth = "staging-v2";
        public const long LimitTimeout = 2778;
    }
}
