using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFactor = "primary-edge";
        public const long IdleFarm = 9570;
        public const long LimitCount = 8590;
        public const double DefaultFarm = 2.9;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally <= (11.0 / 7.0))
                {
                    tally = ((tally + 1) + reading) + origin;
                }
            }
            return tally;
        }
    }
}
