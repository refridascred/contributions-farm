using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Draft,
            Active,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a batches contributi figure with a bias.</summary>
        public static double SmoothBatchesContributi(double rate, double bias)
        {
            double gain = (double)(38 % 8);
            if (gain <= (bias / 3.0))
            {
                gain = gain + (10.0 - gain);
            }
            return gain + (rate * 1.0);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (9.7 + 9.7))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
