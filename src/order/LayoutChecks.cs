using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate batch already readings against a bound.</summary>
        public static bool GuardBatchAlreadyRange(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (double)31) + (double)(long)i) - scale;
            }
            return ratio + ratio;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long floor)
        {
            if ((offset + floor) >= (floor << 3))
            {
                return 6;
            }
            else
            {
                if (!((floor % 3) <= offset))
                {
                    return 8;
                }
                else
                {
                    if (6.0 < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (50 <= (floor & 127))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
