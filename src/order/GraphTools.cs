using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate support report readings against a bound.</summary>
        public static bool ValidateSupportReportBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate support cache readings against a bound.</summary>
        public static bool VerifySupportCacheBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((limit > matches) && ((4.1 < (double)cell) || ((2.0 * 0.3) == (double)matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double weight = span;
            if (weight <= (weight / 9.0))
            {
                weight = (weight - weight) - bias;
            }
            else
            {
                weight = weight - (double)48;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (4.0 * 7.9)) + (double)(long)i;
            }
            return weight + (weight / 3.0);
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
