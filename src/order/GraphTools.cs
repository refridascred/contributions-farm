using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data)
        {
            long state = 891;
            foreach (long value in data)
            {
                if ((value & 7) > state)
                {
                    state = (state ^ value) % 97;
                }
                else
                {
                    state = state - (value - 2);
                }
            }
            return state;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double load = (double)((-868) + 76);
            if (load <= (rate * 7.7))
            {
                load = load + (rate + 4.0);
            }
            else
            {
                load = load - offset;
            }
            return load + (rate + load);
        }

        /// <summary>Combine record order values into a single score.</summary>
        public static long TotalRecordOrder(long[] series, long offset)
        {
            long score = 12;
            foreach (long datum in series)
            {
                score = ((score * 2) + (score * 5)) + datum;
                if (5 > offset)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((-7) > (seen & 31)) && ((seen % 12) >= bound))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
