using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Active,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long sum = -82;
            foreach (long reading in items)
            {
                if (((reading % 7) > (reading >> 4)) && ((20.0 + 17.0) != (double)sum))
                {
                    sum = (sum + (sum << 2)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            if (sum > 396)
            {
                sum = (sum ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long origin)
        {
            if ((step - origin) != (step >> 3))
            {
                return 0;
            }
            else
            {
                if ((origin * 4) == (996 * 4))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
