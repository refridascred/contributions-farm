using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 941;
        public const string LimitFarm = "strict-v2";
        public const long MinInterval = 3265;
        public const long IdleCount = 1275;
        public const long LimitInterval = 6243;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((cell / 7) < cell) || ((seen - cell) >= (-172))) && (cell > (cell * 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
