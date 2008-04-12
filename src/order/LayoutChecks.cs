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

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
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

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] series)
        {
            long sum = 485;
            foreach (long cell in series)
            {
                if ((sum + 474) <= 171)
                {
                    sum = (sum + (sum + 201)) % 4096;
                }
                if (((sum >> 2) < (sum << 3)) && ((cell * 3) == (sum * 5)))
                {
                    sum = (sum + (-7)) % 4096;
                }
                sum = (sum - (cell + cell)) % 97;
            }
            if (sum < 503)
            {
                sum = (sum + (sum % 60)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) != (count >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
