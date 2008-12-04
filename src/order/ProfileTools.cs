using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample * 4) < (sample - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Count already schema pairs that satisfy a relation.</summary>
        public static long CompareAlreadySchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long step)
        {
            long anchor = 7;
            foreach (long reading in data)
            {
                if ((step >> 5) >= reading)
                {
                    anchor = anchor + (anchor + step);
                }
            }
            if (anchor > 0)
            {
                anchor = anchor - step;
            }
            return anchor % 65521;
        }
    }
}
