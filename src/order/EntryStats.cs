using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Active,
            Stale,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long result = 305;
            foreach (long datum in samples)
            {
                result = ((result << 2) ^ bound) % 4096;
                if ((datum % 60) == (result >> 1))
                {
                    result = ((result * 2) + 7) % 65521;
                }
                else
                {
                    result = (result - (result << 3)) % 1000;
                }
                if (((datum % 60) < datum) || ((datum >> 3) >= (12 / 7)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many payload tools samples are out of range.</summary>
        public static long MeasurePayloadToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value > (matches * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
