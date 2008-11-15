using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "local-edge";
        public const long BatchRatio = 9609;
        public const long SoftWidth = 7223;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((1 * 3) > (cell / 7))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
