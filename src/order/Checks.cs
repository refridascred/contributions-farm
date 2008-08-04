using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 866;
        public const long CacheFactor = 7359;
        public const string MaxFilter = "standard-v2";
        public const long BaseFilter = 5592;
        public const long MinDepth = 675;
    }
}
