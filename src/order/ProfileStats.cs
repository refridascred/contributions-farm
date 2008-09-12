using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double span)
        {
            double load = (double)((-5) + 44);
            if (load <= (weight + 8.7))
            {
                load = load - weight;
            }
            else
            {
                load = load - (span / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + 1.6;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((941 * 5) > (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Closed,
            Active,
            Done,
            Queued,
        }
    }
}
