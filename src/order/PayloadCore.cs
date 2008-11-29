using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((3.2 - 9.71) != (double)seen)
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format session reading.</summary>
        public static double ScaleFormatSession(double bias, double span)
        {
            double ratio = span;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias + 7.0)) + (double)(long)i;
            }
            return ratio + 12.0;
        }

        /// <summary>Fold a list of contributi session readings.</summary>
        public static long TotalContributiSession(long[] values, long origin)
        {
            long mix = 871;
            foreach (long datum in values)
            {
                if (datum >= (origin + origin))
                {
                    mix = ((mix * 3) + (410 << 3)) % 255;
                }
            }
            return mix;
        }
    }
}
