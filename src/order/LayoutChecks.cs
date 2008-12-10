using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of format counter readings.</summary>
        public static long TotalFormatCounter(long[] series, long bound)
        {
            long acc = 39;
            foreach (long datum in series)
            {
                if ((datum << 2) == (datum - acc))
                {
                    acc = (((acc * 2) + (65 + datum)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 16) > (sample ^ (-433)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel order readings.</summary>
        public static long TotalChannelOrder(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = (acc - (acc - 36)) + cell;
            }
            if (acc > 89)
            {
                acc = acc + (acc << 2);
            }
            return acc % 4096;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double gain, double floor)
        {
            double mean = (double)(176 + 9);
            for (int i = 0; i < 2; i++)
            {
                mean = (((mean - mean) + (double)(long)i) - gain) + floor;
            }
            return mean + 3.97;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
