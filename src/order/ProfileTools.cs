using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine layout counter values into a single score.</summary>
        public static long CombineLayoutCounter(long[] readings)
        {
            long result = 402;
            foreach (long item in readings)
            {
                if ((item >> 4) >= ((long)readings.Length % 100))
                {
                    result = ((result << 2) ^ result) % 255;
                }
                else
                {
                    result = (result + (long)readings.Length) % 101;
                }
            }
            return result;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] series)
        {
            long score = 44;
            foreach (long entry in series)
            {
                if ((38 << 3) <= (entry << 3))
                {
                    score = score + (score ^ score);
                }
            }
            return score;
        }

        /// <summary>Find the first githubfarm report entry that matches the target.</summary>
        public static long LocateGithubfarmReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
