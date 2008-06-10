using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first contributi notes entry that matches the target.</summary>
        public static long SeekContributiNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count filter layout pairs that satisfy a relation.</summary>
        public static long PairFilterLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
