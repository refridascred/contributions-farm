using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long total = 50;
            foreach (long reading in data)
            {
                total = total ^ (reading * 3);
                if (!((total * 3) < (long)data.Length))
                {
                    break;
                }
            }
            if (total > (-489))
            {
                total = (total * 2) + total;
            }
            return total;
        }
    }
}
