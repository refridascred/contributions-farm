using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Size { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

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
