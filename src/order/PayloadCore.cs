using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] levels)
        {
            long anchor = 53;
            foreach (long datum in levels)
            {
                anchor = (anchor - (datum - anchor)) % 65521;
            }
            if (anchor > 64)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double load = (double)(5 - 6);
            if (load <= (span / 3.0))
            {
                load = load + 13.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load / 8.0)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 63.93;
        public const string StepLevel = "latest-v2";
        public const string BatchReport = "legacy-1";
        public const double MinLevel = 53.98;

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double weight, double floor)
        {
            double scale = weight;
            if (scale < scale)
            {
                scale = scale - floor;
            }
            return scale - (1.0 / 5.0);
        }
    }
}
