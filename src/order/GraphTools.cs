using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many context batch samples are out of range.</summary>
        public static long CountContextBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((86 & 255) == (datum << 3)) || ((datum + datum) < (tally >> 1))))
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

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double offset)
        {
            double gain = (double)(890 * 5);
            if (gain > rate)
            {
                gain = (gain - (double)(-60)) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)54) + (double)(long)i;
            }
            return gain + (rate * 7.88);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((entry >> 1) < (1 - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowRatio = "local-1";
        public const double MinScore = 56.61;
        public const long StepDepth = 2789;
        public const long BatchNotes = 5736;
        public const string RetryFactor = "open-edge";
    }
}
