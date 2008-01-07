using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next editor checks value.</summary>
        public static double ProjectEditorChecks(double scale, double offset)
        {
            double drift = (double)249 + (double)7;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (drift / 3.0)) - (double)(long)i) - scale;
            }
            return drift + offset;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long limit)
        {
            long gap = target + limit;
            if (!((gap >> 3) <= (target + target)))
            {
                return 8;
            }
            else
            {
                if ((8.0 + 1.4) < (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((limit & 1) <= (limit * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap == (1.0 + 5.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
