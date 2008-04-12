using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double weight, double offset)
        {
            double load = 7.0;
            if (load > weight)
            {
                load = (load - (weight - load)) - offset;
            }
            return load + 11.0;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = -2;
            foreach (long datum in values)
            {
                if ((936 - datum) < total)
                {
                    total = (total - datum) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Failed,
            Done,
            Idle,
            Draft,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 8224;
        public const long BatchStats = 9918;
        public const long SoftSpan = 6794;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
