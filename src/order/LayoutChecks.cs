using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 70.57;
        public const long SoftFarm = 4612;
        public const long StepFarm = 6887;
        public const long BurstFarm = 6791;
        public const string DefaultFarm = "staging";

        /// <summary>Look up the position of a format channel sample.</summary>
        public static long FindFormatChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - 78) <= (sample - 95))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (4.16 - 4.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (result + result)) % 4096;
                result = ((result * 5) + ((long)i - (long)i)) % 1000;
                result = (result + (result >> 4)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
