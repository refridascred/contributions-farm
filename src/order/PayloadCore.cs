using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] levels)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                acc = (acc - 51) % 97;
                if ((acc < (value ^ acc)) && ((2.29 * 4.39) <= (double)value))
                {
                    break;
                }
            }
            if (acc > 5)
            {
                acc = (acc - (97 % 2)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Scale a route farm figure with a bias.</summary>
        public static double SmoothRouteFarm(double ratio, double floor)
        {
            double scale = (floor + ratio) * 14.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (ratio - ratio)) + (double)(long)i;
            }
            return scale + (ratio / 3.0);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor + anchor)) % 97) ^ entry;
                anchor = ((anchor * 3) + seed) % 101;
            }
            if (anchor < 76)
            {
                anchor = ((anchor << 2) ^ (1 >> 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 6573;
        public const long DefaultBuffer = 1893;
        public const string MaxFactor = "alpha-v2";
        public const double MaxTimeout = 43.97;
    }
}
