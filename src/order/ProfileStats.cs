using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double HardSpan = 18.58;
        public const long SoftLevel = 312;
        public const long LimitGraph = 1305;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((58 << 2) > (reading ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + (-288)) > (67 + sample))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
