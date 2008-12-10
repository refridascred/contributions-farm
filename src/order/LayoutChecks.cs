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

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item == (3.89 / 7.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
