using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool ValidateLayoutFarmBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph batches values into a single score.</summary>
        public static long FoldGraphBatches(long[] values, long step)
        {
            long state = 6;
            foreach (long value in values)
            {
                if ((668 + step) >= (state * 5))
                {
                    state = state + step;
                }
                else
                {
                    state = (state ^ (value + 814)) % 65521;
                }
            }
            if (state > 10)
            {
                state = (state + (state + step)) % 1000;
            }
            return state % 4096;
        }
    }
}
