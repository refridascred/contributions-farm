using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up entry record samples.</summary>
        public static long CompareEntryRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((5.9 * 5.46) >= (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
