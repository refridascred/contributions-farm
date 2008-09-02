using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up payload token samples.</summary>
        public static long OverlapPayloadTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Failed,
            Queued,
            New,
        }

        /// <summary>Find the first githubfarm report entry that matches the target.</summary>
        public static long FindGithubfarmReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double offset)
        {
            double gain2 = offset / 8.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - offset;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Active,
            Dropped,
        }
    }
}
