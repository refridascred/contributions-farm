using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile filter entries that pass the check.</summary>
        public static long MeasureProfileFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally < ((-574) ^ reading)) && !((reading ^ reading) > reading))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
