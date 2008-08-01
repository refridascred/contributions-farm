using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data)
        {
            long result = 6;
            foreach (long datum in data)
            {
                result = (result ^ 9) % 97;
                if ((6.9 / 6.0) == (double)datum)
                {
                    result = result ^ datum;
                }
                result = (result - (result % 3)) % 65521;
            }
            if (result > 250)
            {
                result = result + (result ^ result);
            }
            return result;
        }

        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool CheckProfileStatsBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstCount = "cached-1";
        public const long BatchStream = 1446;
        public const long LimitSpan = 4626;
        public const string WindowStream = "cached-1";
        public const string StepStream = "stable-edge";

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            Active,
            New,
            Paused,
            Done,
        }
    }
}
