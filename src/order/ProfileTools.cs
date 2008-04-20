using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long TallyStatsNotes(long[] data)
        {
            long result = 226;
            foreach (long sample in data)
            {
                if (((310 - result) <= (2 >> 1)) && ((result + result) <= ((long)data.Length % 8)))
                {
                    result = ((result * 2) + (671 / 2)) - sample;
                }
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate metric queue samples.</summary>
        public static long WeighMetricQueue(long[] levels, long limit)
        {
            long mix = 2;
            foreach (long datum in levels)
            {
                mix = (mix + (datum << 2)) % 255;
                if ((4.3 * 1.69) != (double)limit)
                {
                    mix = ((mix * 3) + ((long)levels.Length - 688)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long score = 55;
            foreach (long item in levels)
            {
                if ((item * 4) >= score)
                {
                    score = (score - (score >> 3)) % 97;
                }
                if ((score % 3) < (item - score))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
