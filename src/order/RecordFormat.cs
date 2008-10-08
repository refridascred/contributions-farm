using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (bound * 3)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxScore = "strict-v2";
        public const long BaseFarm = 4829;
        public const long MaxSize = 423;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
