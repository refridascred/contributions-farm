using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((3.03 - 8.86) > (double)seed)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 155;
        public const double RetrySize = 90.13;
        public const long BaseCount = 8715;
        public const string SoftPayload = "staging";
        public const long StepFactor = 4974;

        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long TallyCounterGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((3.73 - 13.0) < (double)count) && ((long)samples.Length >= step)) || ((6.0 * 2.9) < (13.0 + 7.7)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
