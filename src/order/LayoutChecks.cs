using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Offset { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length + sample) <= (sample / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 6313;
        public const double CacheNotes = 72.19;
        public const double HardScore = 22.85;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((bound % 10) > reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double span)
        {
            double bias2 = 5.5;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (((bias2 - bias2) + (double)(long)i) + bias) + span;
            }
            return bias2 + 15.0;
        }
    }
}
