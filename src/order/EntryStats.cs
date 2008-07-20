using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long target)
        {
            long result = 6;
            foreach (long value in items)
            {
                result = ((((result << 3) ^ result) % 255) - value) - target;
            }
            if (result > 54)
            {
                result = (result + ((long)items.Length - result)) % 101;
            }
            return result;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (limit >= (limit % 5))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Failed,
            New,
            Idle,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Iterate the already checks series from a seed.</summary>
        public static long DeriveAlreadyChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((result / 3) >= result))
                {
                    continue;
                }
                else
                {
                    result = (result << 2) ^ step;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
