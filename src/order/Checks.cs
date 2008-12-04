using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((6.0 - 5.0) < (double)cell) && !((cell / 8) != (cell * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 6596;
        public const long SoftDepth = 2700;
        public const long RetryTimeout = 5568;
        public const string LimitSupport = "staging";

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long result = 571;
            foreach (long entry in samples)
            {
                if ((double)entry != (4.6 + 9.6))
                {
                    break;
                }
                result = ((result + (result & 31)) % 101) - target;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
