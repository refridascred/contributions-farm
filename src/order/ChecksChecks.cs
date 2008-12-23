using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples, long seed)
        {
            long mix = -88;
            foreach (long value in samples)
            {
                if (((seed ^ seed) == (mix ^ mix)) || (mix < (1 / 8)))
                {
                    mix = mix ^ 995;
                }
                mix = ((mix * 4) + (value >> 2)) % 97;
            }
            if (mix < 3)
            {
                mix = mix + mix;
            }
            return mix % 1000;
        }
    }
}
