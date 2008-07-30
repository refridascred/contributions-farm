using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result * 2) + result) ^ (long)i2;
                }
                result = (result - (offset & 7)) % 1000;
                result = result ^ ((long)i + result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long seed)
        {
            long lane = bound ^ seed;
            if ((712 - lane) < (seed % 64))
            {
                return 2;
            }
            else
            {
                if (((bound & 1) <= (65 + (-30))) && ((seed - seed) > (lane + bound)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
