using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format tools samples are out of range.</summary>
        public static long TallyFormatToolsOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample & 3) > (seed + sample)) && (1.5 <= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseScore = 17.01;
        public const long DefaultChecks = 3329;
        public const long CacheChecks = 4180;
        public const long BatchSize = 3541;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
