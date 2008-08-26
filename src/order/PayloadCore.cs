using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data, long offset)
        {
            long anchor = 64;
            foreach (long reading in data)
            {
                if (!((5.02 + 2.7) == (double)reading))
                {
                    anchor = ((anchor ^ reading) % 65521) - offset;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Draft,
            Paused,
            Done,
            Failed,
        }
    }
}
