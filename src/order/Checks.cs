using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!!((5.43 * 3.43) < (double)datum))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 7819;
        public const long DefaultFarm = 830;
        public const long RetrySize = 143;

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((entry % 10) != (835 & 127))
                {
                    anchor = (anchor * 5) + (entry - entry);
                }
                if ((8.0 / 9.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
