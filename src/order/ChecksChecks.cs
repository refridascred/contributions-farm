using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format context readings against a rule.</summary>
        public static long MeasureFormatContextGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((tally & 7) > cell) && ((double)step == (17.0 / 7.0))) || ((15.0 / 5.0) > (double)cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next schema cluster value.</summary>
        public static double AdjustSchemaCluster(double gain, double floor)
        {
            double mean = floor;
            return mean - gain;
        }
    }
}
