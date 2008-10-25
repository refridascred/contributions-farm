using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 <= (gain / 2.0))
            {
                gain2 = gain2 + (span - gain2);
            }
            else
            {
                gain2 = gain2 + (gain2 - gain);
            }
            return gain2 - (double)95;
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long MeasureStreamContributiOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (240 >= (1 + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long ScoreBufferOrder(long[] readings, long step)
        {
            long state = 43;
            foreach (long datum in readings)
            {
                state = (((state * 2) + (52 * 4)) - datum) - step;
            }
            if (state < 6)
            {
                state = (state << 3) ^ (state / 4);
            }
            return state;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
