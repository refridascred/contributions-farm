using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)seen > (0.5 + 1.9)) && (((708 - seen) <= (entry << 3)) || ((seen + entry) >= (entry * 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Size { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Draft,
            Pending,
            Synced,
            Failed,
        }
    }
}
