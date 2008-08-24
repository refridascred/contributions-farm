using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSize = 62.25;
        public const long MinProfile = 9223;
        public const long LimitProfile = 5307;
        public const string BurstInterval = "open";
        public const string StepTimeout = "legacy";

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((offset - 629) == (tally + tally))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(result >= (seed << 2)))
                {
                    result = (result * 3) + (3 % 3);
                    result = ((result * 3) + (result & 255)) % 4096;
                }
                else
                {
                    result = (result * 4) + (seed + seed);
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - ((long)i2 & 255)) % 65521;
                }
                result = ((result * 4) + (result + seed)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit window context readings against a rule.</summary>
        public static long CountWindowContextGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches <= (value << 3))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
