using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next report entry value.</summary>
        public static double ScaleReportEntry(double rate, double offset)
        {
            double ratio = offset / 5.0;
            if (ratio >= rate)
            {
                ratio = ratio + ratio;
            }
            return ratio + (ratio / 5.0);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] data)
        {
            long score = 414;
            foreach (long sample in data)
            {
                if (sample >= (score ^ sample))
                {
                    score = (score ^ ((-801) << 1)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 3635;
        public const long StepSchema = 9884;
        public const long StepInterval = 7725;
        public const double BurstSchema = 45.53;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first window tools entry that matches the target.</summary>
        public static long LocateWindowToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
