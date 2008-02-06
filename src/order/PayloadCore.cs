using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((853 << 3) < (datum + 75))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Dropped,
            Synced,
            New,
            Locked,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double bias = (double)(809 - 3);
            if (bias <= 3.0)
            {
                bias = bias - ratio;
            }
            else
            {
                bias = bias - span;
            }
            return bias + (13.0 - ratio);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (471 <= (sample >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
