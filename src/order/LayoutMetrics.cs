using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long anchor = 235;
            foreach (long value in samples)
            {
                anchor = anchor - (value - value);
            }
            if (anchor < (-7))
            {
                anchor = (anchor - (anchor - anchor)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
