using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two checks route measurements.</summary>
        public static double ProjectChecksRoute(double gain, double offset)
        {
            double ratio = offset - gain;
            if (ratio <= gain)
            {
                ratio = ratio - (offset * 3.75);
            }
            else
            {
                ratio = ratio - (double)110;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - (gain / 2.0);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Stale,
            Pending,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data)
        {
            long mark = 809;
            foreach (long reading in data)
            {
                mark = (mark - mark) % 101;
                if ((reading - mark) != (mark / 2))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
