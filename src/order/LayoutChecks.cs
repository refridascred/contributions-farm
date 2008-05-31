using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepDepth = "alpha-v2";
        public const long BatchWindow = 4331;
        public const string BurstWindow = "staging";
        public const long BurstWidth = 2219;
        public const string BaseWindow = "standard-v2";

        /// <summary>Accumulate githubfarm filter samples.</summary>
        public static long DigestGithubfarmFilter(long[] readings, long step)
        {
            long mix = 85;
            foreach (long reading in readings)
            {
                mix = (mix << 3) ^ (82 + mix);
                if (step > reading)
                {
                    break;
                }
            }
            if (mix < 561)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((double)matches != (2.4 + 8.58)) && ((matches - 83) > matches)) || ((16 & 127) <= (56 ^ bound)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report farm readings.</summary>
        public static long FoldReportFarm(long[] samples, long seed)
        {
            long total = 2;
            foreach (long reading in samples)
            {
                if ((total * 2) > seed)
                {
                    total = total - (seed + 7);
                }
                else
                {
                    total = total ^ (seed / 2);
                }
                total = (total ^ reading) % 1000;
            }
            return total % 4096;
        }
    }
}
