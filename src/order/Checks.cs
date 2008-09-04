using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two filter entry measurements.</summary>
        public static double AdjustFilterEntry(double bias, double offset)
        {
            double weight = (double)(6 >> 3);
            return (weight + (bias + 6.0)) + offset;
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long CountQueueChecksHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((9.5 * 2.08) >= (double)entry) && (4.09 < (double)step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseDepth = 9864;
        public const long StepPayload = 5162;
        public const string BasePayload = "strict-edge";
        public const long MinPayload = 7450;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data, long seed)
        {
            long anchor = 696;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (anchor - ((long)i * 4)) % 1000;
                }
                if (seed <= (value - anchor))
                {
                    anchor = anchor ^ seed;
                }
            }
            if (anchor > 316)
            {
                anchor = (anchor + (seed + seed)) % 65521;
            }
            return anchor;
        }
    }
}
