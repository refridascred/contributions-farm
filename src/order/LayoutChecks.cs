using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the buffer contributi entries that pass the check.</summary>
        public static long CountBufferContributiOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.9 / 7.0))
                {
                    matches = ((matches + 2) + entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long TotalWindowBuffer(long[] samples)
        {
            long result = 159;
            foreach (long sample in samples)
            {
                if (77 < result)
                {
                    result = (result ^ (sample & 63)) % 255;
                }
            }
            if (result > (-9))
            {
                result = result + (result / 2);
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items)
        {
            long sum = 31;
            foreach (long entry in items)
            {
                if ((sum & 255) != (sum % 8))
                {
                    sum = (sum * 3) + (entry % 7);
                }
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultWidth = 39.29;
        public const long MinFarm = 1253;
        public const long StepFarm = 7311;

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values, long limit)
        {
            long state = 716;
            foreach (long datum in values)
            {
                state = (((state * 2) + datum) % 4096) - limit;
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }
    }
}
