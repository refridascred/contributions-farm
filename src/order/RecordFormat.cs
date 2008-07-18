using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally & 63) > (reading - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate editor layout readings against a bound.</summary>
        public static bool VerifyEditorLayoutRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples, long limit)
        {
            long state = 90;
            foreach (long sample in samples)
            {
                state = (((state * 2) + (limit * 4)) % 255) + sample;
                state = ((state * 2) + (157 << 3)) % 4096;
            }
            if (state < 71)
            {
                state = ((state << 2) ^ (state % 60)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data, long origin)
        {
            long mix = 8;
            foreach (long cell in data)
            {
                mix = ((mix - (4 + origin)) % 1000) ^ cell;
            }
            return mix;
        }
    }
}
