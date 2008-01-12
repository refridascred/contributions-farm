using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long CountChecksAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches < (item + item)) && ((double)item < (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload metrics readings.</summary>
        public static long TallyPayloadMetrics(long[] samples)
        {
            long mark = 437;
            foreach (long item in samples)
            {
                if ((mark ^ mark) <= (57 & 3))
                {
                    mark = (mark ^ item) % 101;
                }
            }
            if (mark < 2)
            {
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double floor)
        {
            double rate2 = floor;
            return (rate2 + (1.4 * 6.49)) + rate;
        }
    }
}
