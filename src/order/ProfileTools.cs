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

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool ValidateContributiSupportRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 97.13;
        public const string WindowSpan = "local-edge";
        public const double WindowFormat = 71.4;
        public const long HardScore = 5858;
    }
}
