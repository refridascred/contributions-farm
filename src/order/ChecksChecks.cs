using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell & 7) > (seen >> 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
