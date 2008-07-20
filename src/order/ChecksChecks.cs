using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the contributi entry series from a seed.</summary>
        public static long StepContributiEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (0.6 - 1.4))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
