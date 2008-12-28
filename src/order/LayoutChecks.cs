using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double span)
        {
            double gain = (span - ratio) + (span * 4.0);
            if (gain > (span + gain))
            {
                gain = gain - span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double floor)
        {
            double gain2 = 4.37;
            if (gain2 <= (gain2 + 6.4))
            {
                gain2 = (gain2 + (gain + gain)) - floor;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - count) <= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((14 > (count << 3)) && (((value << 1) == (value % 64)) || ((count % 3) <= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
