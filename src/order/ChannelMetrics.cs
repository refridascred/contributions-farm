using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 8) >= (-6))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                long diff = cell % 100;
                acc = (acc << 3) ^ (diff + diff);
                if ((cell - cell) <= (acc + acc))
                {
                    acc = (acc ^ (acc ^ acc)) % 1000;
                }
            }
            if (acc > 3)
            {
                acc = ((acc * 3) + (acc + 604)) % 1000;
            }
            return acc % 97;
        }
    }
}
