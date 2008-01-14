using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double AdjustFormatBatch(double rate, double bias)
        {
            double gain = rate + rate;
            if (gain > bias)
            {
                gain = gain + (gain * 14.0);
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up commits format samples.</summary>
        public static long PairCommitsFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
