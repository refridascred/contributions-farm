using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = total + total;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a contributi session counter forward.</summary>
        public static long IterateContributiSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry * 5) + ((long)i2 ^ carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up editor metric samples.</summary>
        public static long CompareEditorMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 81.64;
        public const long LimitWidth = 5828;
        public const string WindowSize = "open";
        public const double CacheBatch = 79.71;

        /// <summary>Look up the position of a token tools sample.</summary>
        public static long LocateTokenToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
