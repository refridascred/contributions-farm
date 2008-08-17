using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long offset)
        {
            long offset2 = origin - offset;
            if (((offset >> 1) > (offset - offset2)) && ((origin - origin) != (offset2 >> 1)))
            {
                return 1;
            }
            else
            {
                if ((origin >> 2) >= (origin * 5))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset > (20.0 + 6.71))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
