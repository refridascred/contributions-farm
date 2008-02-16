using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long seed)
        {
            if (seed >= (seed >> 5))
            {
                return 1;
            }
            else
            {
                if ((95 * 5) < (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed >= (seed & 3)) && ((floor ^ floor) == (168 + 76)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long score = 81;
            foreach (long sample in readings)
            {
                if (sample >= 0)
                {
                    score = ((score << 2) ^ (sample >> 4)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count - target) < (6 / 2))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
