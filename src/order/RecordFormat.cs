using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (89 < tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 3896;
        public const string MaxInterval = "standard-edge";
        public const double SoftPayload = 82.28;
        public const long BurstPayload = 6771;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long target)
        {
            long total = 813;
            foreach (long entry in readings)
            {
                total = (total ^ entry) - target;
                if ((double)total >= (double)(-52))
                {
                    total = (total ^ (330 & 31)) % 1000;
                }
                else
                {
                    total = (total + (entry & 7)) % 97;
                }
                if (total >= entry)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a session tools sample.</summary>
        public static long LocateSessionToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
