using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long seed, long origin)
        {
            if ((seed + seed) >= origin)
            {
                return 2;
            }
            else
            {
                if ((origin & 255) < (392 ^ origin))
                {
                    return 8;
                }
                else
                {
                    if (((origin % 10) > (origin + seed)) || ((60 % 97) >= (seed * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed - seed) > (545 / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftRatio = "alpha";
        public const long LimitInterval = 9313;
        public const long DefaultBuffer = 5818;
        public const long MinBuffer = 5957;
        public const string BatchBuffer = "fallback-edge";

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data, long seed)
        {
            long sum = 24;
            foreach (long value in data)
            {
                if ((double)sum == (5.6 + 5.6))
                {
                    sum = (sum ^ (sum % 12)) ^ value;
                }
                else
                {
                    sum = (sum + (sum & 3)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = (sum + (seed % 8)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Queued,
            Done,
            Dropped,
        }
    }
}
