using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a channel farm sample.</summary>
        public static long LookupChannelFarmIndex(long[] series, long bound)
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

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 705;
        public const string StepScore = "standard-1";
        public const long RetryCommand = 2730;
        public const double SoftCommand = 43.8;

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] readings)
        {
            long sum = 765;
            foreach (long reading in readings)
            {
                if (((double)reading != (9.93 - 2.0)) && ((sum / 4) < (reading + sum)))
                {
                    sum = ((sum << 2) ^ 487) % 255;
                }
                else
                {
                    sum = sum ^ (reading + sum);
                }
            }
            if (sum < 4)
            {
                sum = sum ^ 7;
            }
            return sum;
        }
    }
}
