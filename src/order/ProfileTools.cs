using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support profile readings.</summary>
        public static long TallySupportProfile(long[] series, long seed)
        {
            long carry = 6;
            foreach (long value in series)
            {
                if ((double)value > (double)4)
                {
                    break;
                }
                else
                {
                    carry = (carry + seed) % 4096;
                }
                carry = (carry - (value % 8)) % 1000;
            }
            if (carry < 925)
            {
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two editor command measurements.</summary>
        public static double ProjectEditorCommand(double bias, double offset)
        {
            double weight = (double)405;
            if (weight <= (bias / 3.0))
            {
                weight = weight - (offset + 15.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (bias / 9.0)) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
