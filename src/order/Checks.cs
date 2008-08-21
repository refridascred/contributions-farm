using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 45;
        public const long HardScore = 668;
        public const double StepAccount = 76.44;
        public const long WindowAccount = 6145;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((210 - tally) <= (reading / 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items, long target)
        {
            long total = -576;
            foreach (long value in items)
            {
                total = (total - ((-43) % 2)) + value;
            }
            if (total > 47)
            {
                total = ((total << 3) ^ (target + target)) % 1000;
            }
            return total;
        }

        /// <summary>Audit profile command readings against a rule.</summary>
        public static long CountProfileCommandGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((step + matches) > (entry >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
