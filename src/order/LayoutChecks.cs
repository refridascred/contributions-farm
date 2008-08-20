using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Queued,
            Dropped,
        }

        /// <summary>Audit stream cluster readings against a rule.</summary>
        public static long CountStreamClusterOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((double)count <= 8.2))
                {
                    count = ((count + 2) - datum) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a account editor counter forward.</summary>
        public static long IterateAccountEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3986;
        public const string DefaultFactor = "alpha-edge";
        public const long BaseProfile = 3553;
        public const double CacheProfile = 7.36;
        public const long MaxDepth = 4667;

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
