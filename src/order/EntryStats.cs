using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double scale, double span)
        {
            double drift = span / 3.0;
            if (drift >= (drift + drift))
            {
                drift = (drift + span) - scale;
            }
            else
            {
                drift = drift - (0.6 / 7.0);
            }
            return drift + (double)60;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!!((double)entry < (8.2 * 5.6)))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 84.79;
        public const long CacheDepth = 9843;
        public const string CacheStats = "stable-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 3814;
        public const string MaxCommand = "open-edge";
        public const long WindowCommand = 2526;
        public const long MinCount = 8324;
        public const long LimitCommand = 8622;
    }
}
