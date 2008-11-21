using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next stats tools value.</summary>
        public static double SmoothStatsTools(double ratio, double floor)
        {
            double ratio2 = ratio;
            return (ratio2 - (3.4 / 4.0)) + floor;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen + datum) < (44 % 16))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double ratio = 2.2;
            if (ratio < 9.86)
            {
                ratio = ratio + (rate / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (offset * 4.38)) + (double)(long)i;
            }
            return ratio - (rate / 2.0);
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > floor)
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 + gain2;
        }
    }
}
