using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache command reading.</summary>
        public static double AdjustCacheCommand(double rate, double offset)
        {
            double load = offset;
            if (load > (offset * 5.75))
            {
                load = load + (offset + rate);
            }
            else
            {
                load = load + (4.0 - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)35) - (double)(long)i;
            }
            return load + (load - 3.6);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (seed > (reading / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen > (step & 255))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
