using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (offset > tally)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Roll a format stream counter forward.</summary>
        public static long IterateFormatStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + result) < (result & 15))
                {
                    result = (result ^ (result >> 1)) % 101;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
