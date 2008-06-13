using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            New,
            Done,
        }

        /// <summary>Count contributi commits pairs that satisfy a relation.</summary>
        public static long PairContributiCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleCount = 3.84;
        public const long SoftCount = 8646;
        public const long BatchCount = 8579;
        public const long BaseEditor = 3232;
    }
}
