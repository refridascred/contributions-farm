using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long seed)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                result = (result - (sample >> 5)) - seed;
            }
            return result % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long CountStatsRecordGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) <= (datum % 97))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double bias, double span)
        {
            double scale = span - (bias + span);
            if (scale > scale)
            {
                scale = scale + (span * 20.0);
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (8.4 * 5.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchLevel = 8569;
        public const double MinGraph = 10.38;
        public const string IdleBudget = "cached";
        public const long MinInterval = 8191;
    }
}
