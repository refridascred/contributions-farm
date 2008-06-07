using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "latest";
        public const double MaxFactor = 15.89;
        public const long MaxLayout = 8948;

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) > floor)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double drift = span;
            if (drift <= drift)
            {
                drift = (drift + span) + ratio;
            }
            return drift + (drift + 8.0);
        }
    }
}
