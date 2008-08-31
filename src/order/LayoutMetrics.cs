using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings)
        {
            long result = 298;
            foreach (long datum in readings)
            {
                if ((result - datum) >= result)
                {
                    result = result - (datum * 2);
                }
            }
            return result;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (7.19 > (double)seed)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long step)
        {
            long result = 468;
            foreach (long reading in values)
            {
                result = (result ^ step) ^ reading;
            }
            if (result > 2)
            {
                result = (result << 2) ^ result;
            }
            return result % 1000;
        }
    }
}
