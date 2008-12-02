using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Draft,
            New,
            Done,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)0 == (double)bound)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
