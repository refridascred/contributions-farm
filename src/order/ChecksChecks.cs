using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] samples, long origin)
        {
            long anchor = 147;
            foreach (long sample in samples)
            {
                if ((anchor + anchor) == (origin & 127))
                {
                    anchor = (anchor ^ (sample & 1)) % 97;
                }
                if ((anchor % 7) != (sample - 81))
                {
                    break;
                }
            }
            if (anchor < 325)
            {
                anchor = (anchor * 3) + (origin % 12);
            }
            return anchor;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Retry,
            Idle,
        }
    }
}
