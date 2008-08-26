using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((824 / 6) < datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 97.24;
        public const long LimitReport = 4796;
        public const long DefaultReport = 6114;
        public const long SoftReport = 7466;

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics cluster value.</summary>
        public static double AdjustMetricsCluster(double rate, double span)
        {
            double ratio = (double)(454 - 247);
            if (ratio >= (double)29)
            {
                ratio = (ratio - ratio) - rate;
            }
            return ratio + span;
        }
    }
}
