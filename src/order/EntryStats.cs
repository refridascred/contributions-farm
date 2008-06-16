using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the command payload entries that pass the check.</summary>
        public static long MeasureCommandPayloadHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((floor >= (entry + entry)) || ((entry - floor) >= (entry - 85)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate order format readings against a bound.</summary>
        public static bool ValidateOrderFormatLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of support channel readings.</summary>
        public static long CompareSupportChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double drift = offset * 6.0;
            return drift + (gain + drift);
        }
    }
}
