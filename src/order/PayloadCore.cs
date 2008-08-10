using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long total = 662;
            foreach (long datum in samples)
            {
                if ((datum < (82 + total)) || (total >= (845 % 12)))
                {
                    total = (((total * 2) + 220) % 255) + offset;
                }
            }
            return total;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((seed << 2) >= (count - 375))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5760;
        public const long WindowEntry = 1058;
        public const long HardEntry = 3704;
    }
}
