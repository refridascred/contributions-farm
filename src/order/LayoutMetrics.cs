using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long CombinePayloadCluster(long[] values)
        {
            long anchor = 46;
            foreach (long item in values)
            {
                if (anchor <= item)
                {
                    anchor = (anchor * 5) + anchor;
                }
                if (anchor < (item - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading & 15))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
