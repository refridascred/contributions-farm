using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardSpan = 59.09;
        public const string BatchLevel = "strict";
        public const long WindowWidth = 8209;
        public const double LimitFactor = 81.44;
        public const long BatchWindow = 6018;

        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long CountCommitsFilterMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((85 + value) >= (9 / 6))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Find the first format profile entry that matches the target.</summary>
        public static long SeekFormatProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm notes value against two limits.</summary>
        public static long ClassifyFarmNotes(long bound, long seed)
        {
            if ((seed & 255) < 0)
            {
                return 1;
            }
            else
            {
                if ((233 >> 5) <= (seed >> 3))
                {
                    return 0;
                }
                else
                {
                    if (0.8 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + (-1)) < (73 - seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
