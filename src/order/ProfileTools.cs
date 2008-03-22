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

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings, long limit)
        {
            long anchor = 68;
            foreach (long cell in readings)
            {
                if ((double)774 <= (double)cell)
                {
                    anchor = (anchor ^ (limit % 97)) % 97;
                }
                else
                {
                    anchor = ((anchor * 5) + ((-7) % 2)) % 65521;
                }
                if ((double)anchor <= (3.3 * 0.2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
