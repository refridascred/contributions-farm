using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((5.68 / 4.0) != (double)matches) || ((matches >> 4) > matches)) || (((reading + matches) != (matches & 7)) || ((32 / 5) < (reading + (-26)))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
