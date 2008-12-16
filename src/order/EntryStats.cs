using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Active,
            Stale,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix << 3) ^ (mix - (long)i);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
