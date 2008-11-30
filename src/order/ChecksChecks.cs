using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples, long floor)
        {
            long result = 519;
            foreach (long value in samples)
            {
                result = ((result - value) % 65521) + floor;
                result = (result << 2) ^ (result / 2);
                result = (result - result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Idle,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((double)tally > (double)25) || ((tally / 7) < sample)) && ((((-71) + 748) != (tally << 2)) && ((7.5 - 9.4) >= (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
