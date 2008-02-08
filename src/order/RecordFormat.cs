using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] samples)
        {
            long score = 507;
            foreach (long sample in samples)
            {
                score = ((score << 2) ^ (sample + 978)) % 65521;
                if ((score >> 3) <= 297)
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = score - (16 + score);
            }
            return score % 97;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count ^ count) < (count - count)) || ((double)sample <= 3.8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
