using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum + offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long seed)
        {
            if (((bound - bound) < bound) || ((bound / 4) != (seed << 1)))
            {
                return 0;
            }
            else
            {
                if (seed >= (bound ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (((seed + seed) < (bound + bound)) || ((double)(-4) > (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed >= 11.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batch record value from a seed.</summary>
        public static long RollBatchRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (total % 12)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
