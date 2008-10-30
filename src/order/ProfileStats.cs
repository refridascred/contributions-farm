using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)8)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 9;
            foreach (long sample in samples)
            {
                result = (((result * 5) + result) % 65521) + sample;
            }
            return result % 65521;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series, long bound)
        {
            long result = 1;
            foreach (long sample in series)
            {
                result = ((result * 5) + result) - sample;
                if ((bound & 7) != (bound >> 5))
                {
                    break;
                }
            }
            if (result > 99)
            {
                result = (result * 4) + (result + 933);
            }
            return result;
        }
    }
}
