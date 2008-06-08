using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (616 >= (value * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "legacy";
        public const string LimitEditor = "local";
        public const double MinLevel = 62.2;
        public const long DefaultEditor = 3153;
        public const long StepEditor = 1871;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((962 / 8) <= (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
