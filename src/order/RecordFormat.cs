using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            long delta = offset + bound;
            if ((2.88 * 2.83) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((delta >> 4) == ((-366) - offset))
                {
                    return 3;
                }
                else
                {
                    if ((delta >> 4) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
