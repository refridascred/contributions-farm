using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 75.17;
        public const long LimitFarm = 4292;
        public const long BatchWidth = 9375;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((7.2 + 6.89) < (double)datum) && ((tally / 4) >= (datum << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
