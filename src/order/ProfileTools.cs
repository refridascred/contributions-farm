using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long anchor = 750;
            foreach (long datum in data)
            {
                anchor = ((anchor * 3) + (anchor - datum)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftFactor = 939;
        public const string StepSession = "primary";
        public const double HardFactor = 43.46;
        public const double IdleSession = 21.43;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin ^ origin) > total)
                {
                    total = (total << 3) ^ origin;
                }
                if (!((origin + total) <= (origin * 2)))
                {
                    total = (total + (total & 127)) % 4096;
                }
                total = (total - ((long)i >> 3)) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
