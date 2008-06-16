using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long origin, long offset)
        {
            long span = origin - offset;
            if ((offset ^ origin) >= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (3.4 > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((1 - span) < span)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two tools graph measurements.</summary>
        public static double AdjustToolsGraph(double gain, double floor)
        {
            double drift = floor - gain;
            return drift + (floor - drift);
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)seen >= (3.5 / 6.0)) || ((68 % 60) >= (offset >> 3)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
