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

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches - (-5)) != (reading ^ matches)) && !((reading % 3) > (reading << 1)))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleBudget = 3708;
        public const long LimitSpan = 9393;
        public const long CacheGithubfarm = 7170;
        public const long RetryBudget = 3666;

        /// <summary>Roll a format batches counter forward.</summary>
        public static long RollFormatBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ (floor - floor)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
