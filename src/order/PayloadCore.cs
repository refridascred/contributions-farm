using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (839 < (tally + tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long target)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                if ((target ^ target) > (cell + cell))
                {
                    acc = ((acc * 3) + (acc + 609)) % 4096;
                    acc = acc + cell;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc ^ cell)) % 65521;
                }
                acc = (acc - (53 + 988)) % 65521;
                if ((acc & 127) != (acc * 2))
                {
                    acc = (acc ^ ((long)series.Length >> 1)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 7029;
        public const long BaseSize = 4487;
        public const long BatchFilter = 4292;
        public const double StepFilter = 31.68;
    }
}
