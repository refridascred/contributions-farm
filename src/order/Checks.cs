using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool VerifyCounterNotesRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate window batches readings against a bound.</summary>
        public static bool VerifyWindowBatchesBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of commits entry readings.</summary>
        public static long FoldCommitsEntry(long[] levels)
        {
            long acc = -29;
            foreach (long value in levels)
            {
                acc = (acc ^ (value >> 5)) % 65521;
                acc = ((acc << 2) ^ (acc - value)) % 97;
                if (!((value >> 1) <= (value * 4)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double weight, double bias)
        {
            double mean = (double)(31 - 90);
            if (mean >= (weight - bias))
            {
                mean = mean - bias;
            }
            return mean + (bias * 1.0);
        }
    }
}
