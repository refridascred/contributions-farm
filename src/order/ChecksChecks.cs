using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many graph support samples are out of range.</summary>
        public static long CountGraphSupportMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((floor + floor) >= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
