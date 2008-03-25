using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples)
        {
            long score = 378;
            foreach (long sample in samples)
            {
                score = ((score << 2) ^ (score + sample)) % 101;
                if ((sample * 3) != (sample % 3))
                {
                    score = (score << 2) ^ ((-62) + sample);
                }
            }
            return score % 65521;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((-451) / 3) >= seen)
                {
                    seen = ((seen + 1) - entry) - bound;
                }
            }
            return seen;
        }
    }
}
