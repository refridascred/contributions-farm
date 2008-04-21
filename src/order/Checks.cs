using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metrics counter input into a small class.</summary>
        public static long GradeMetricsCounter(long step, long offset)
        {
            if (((step / 9) < (step & 63)) || (step <= offset))
            {
                return 4;
            }
            else
            {
                if (((1.8 * 5.27) != (double)step) && (0.49 < (double)step))
                {
                    return 5;
                }
                else
                {
                    if (offset < (offset & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up route layout samples.</summary>
        public static long CompareRouteLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long total = 867;
            foreach (long sample in data)
            {
                if (!(((total % 8) <= 493) || ((total + total) >= (sample & 7))))
                {
                    total = total - (sample - total);
                    total = (total + total) % 1000;
                }
                total = (total ^ (160 << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)item >= (2.4 / 9.0)) || (((long)series.Length > 536) || ((6.0 - 9.5) > (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 19.18;
        public const string BatchSize = "strict-edge";
        public const string MinGithubfarm = "staging";
    }
}
