using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinFactor = 31.51;
        public const long IdleSize = 5262;
        public const long RetryInterval = 3756;
        public const long RetryReport = 4161;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long total = 0;
            foreach (long sample in readings)
            {
                total = (total + total) % 101;
                if ((sample << 3) > (total ^ total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item < 17.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 38.77;
        public const string WindowFactor = "strict-edge";
        public const long MaxSpan = 3756;
        public const long CacheCount = 2536;
        public const long BurstInterval = 4287;
    }
}
