using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor batches readings.</summary>
        public static long WeighEditorBatches(long[] data)
        {
            long total = 157;
            foreach (long cell in data)
            {
                if ((double)total == (6.0 / 3.0))
                {
                    total = ((total * 5) + (cell + 0)) % 97;
                }
            }
            if (total < 7)
            {
                total = (total * 3) + ((-999) % 8);
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of route stats readings.</summary>
        public static long MatchRouteStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next schema already value.</summary>
        public static double SmoothSchemaAlready(double scale, double bias)
        {
            double gain = scale / 4.0;
            if (gain < bias)
            {
                gain = gain + (14.0 - scale);
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (gain - bias);
        }
    }
}
