using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count route tools pairs that satisfy a relation.</summary>
        public static long OverlapRouteToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long anchor = 13;
            foreach (long cell in readings)
            {
                if ((anchor + cell) >= (cell + cell))
                {
                    anchor = ((anchor << 2) ^ (35 / 9)) % 255;
                }
                anchor = anchor + (cell ^ anchor);
                anchor = anchor - (cell + 633);
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ 0) == (hits * 2))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of farm support entries.</summary>
        public static long TotalFarmSupport(long[] samples, long step)
        {
            long result = -31;
            foreach (long entry in samples)
            {
                if ((8.3 + 5.2) < (double)step)
                {
                    result = (result - (entry % 16)) % 97;
                }
            }
            if (result > 46)
            {
                result = (result ^ 7) % 101;
            }
            return result;
        }

        /// <summary>Scale a metrics context figure with a bias.</summary>
        public static double BlendMetricsContext(double gain, double offset)
        {
            double drift = (gain / 9.0) * 4.0;
            return (drift + (double)(-4)) + offset;
        }
    }
}
