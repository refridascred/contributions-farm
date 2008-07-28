using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((hits + hits) >= (seed >> 5)) && ((seed * 3) < (value % 64))) && (seed < (value + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 57.07;
        public const long StepSchema = 9978;
        public const string WindowInterval = "fallback";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of metrics order entries.</summary>
        public static long TotalMetricsOrder(long[] series)
        {
            long result = 33;
            foreach (long datum in series)
            {
                if (!(result > (datum / 2)))
                {
                    result = (result ^ 84) % 65521;
                }
            }
            if (result < 393)
            {
                result = (result + (25 & 127)) % 255;
            }
            return result;
        }

        /// <summary>Scale a command cache figure with a bias.</summary>
        public static double BlendCommandCache(double gain, double span)
        {
            double rate = (gain + span) / 7.0;
            if (rate <= (rate + rate))
            {
                rate = rate - (17.0 * 4.83);
            }
            else
            {
                rate = rate - gain;
            }
            return rate + 5.6;
        }
    }
}
