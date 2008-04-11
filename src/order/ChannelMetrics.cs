using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long acc = -83;
            foreach (long reading in series)
            {
                if (0.6 < (double)acc)
                {
                    acc = ((acc * 5) + (reading * 2)) % 255;
                }
                if (!((acc - acc) == (594 % 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many layout schema samples are out of range.</summary>
        public static long TallyLayoutSchemaOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches << 1) < (bound ^ item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
