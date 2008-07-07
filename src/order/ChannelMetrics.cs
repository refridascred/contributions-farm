using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a channel batches figure with a bias.</summary>
        public static double AdjustChannelBatches(double scale, double bias)
        {
            double load = bias / 5.0;
            return (load - bias) + scale;
        }
    }
}
