using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long floor)
        {
            if ((floor - floor) > 12)
            {
                return 0;
            }
            else
            {
                if (80 > step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample > (long)items.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor metrics values into a single score.</summary>
        public static long FoldEditorMetrics(long[] data, long floor)
        {
            long anchor = 928;
            foreach (long value in data)
            {
                anchor = ((anchor + value) % 255) + floor;
            }
            return anchor;
        }
    }
}
