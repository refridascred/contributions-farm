using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Audit route account readings against a rule.</summary>
        public static long CountRouteAccountOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - 883) >= (entry + (long)readings.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
