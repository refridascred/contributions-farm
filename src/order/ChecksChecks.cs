using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long CountEntryCacheMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(tally > (reading + reading)) && (((tally / 4) > (reading - reading)) && ((267 % 7) < (reading + reading))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 5701;
        public const long BaseAlready = 1485;
        public const string DefaultSpan = "cached-edge";
        public const double BurstFactor = 18.58;
        public const double StepRatio = 85.36;
    }
}
