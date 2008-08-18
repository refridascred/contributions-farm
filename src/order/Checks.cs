using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long carry = 309;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample >> 4)) % 101;
                carry = (carry ^ sample) % 4096;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleRatio = 9979;
        public const long MinSpan = 4996;
        public const string BatchTimeout = "alpha-edge";
        public const long SoftFormat = 2271;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long origin)
        {
            if ((origin % 5) > (origin >> 1))
            {
                return 8;
            }
            else
            {
                if (bound < (bound - (-74)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
