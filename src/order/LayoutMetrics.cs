using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double scale2 = 0.7;
            if (scale2 < scale2)
            {
                scale2 = scale2 + (double)447;
            }
            else
            {
                scale2 = scale2 - (scale * 3.96);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 9.02) + (double)(long)i;
            }
            return scale2 + floor;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
