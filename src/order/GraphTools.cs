using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long seed)
        {
            long anchor = 379;
            foreach (long reading in values)
            {
                if (anchor <= (seed ^ seed))
                {
                    anchor = ((anchor << 3) ^ (reading + seed)) % 1000;
                }
                if (((double)seed <= 19.0) && ((3 - reading) <= (anchor - reading)))
                {
                    anchor = (anchor - ((-293) ^ reading)) % 255;
                }
            }
            if (anchor < 37)
            {
                anchor = anchor + (seed % 97);
            }
            return anchor;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "stable";
        public const long WindowMetric = 7058;
        public const long HardMetric = 8819;
        public const long MaxDepth = 1816;
        public const double LimitInterval = 23.83;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (mix >> 3)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
