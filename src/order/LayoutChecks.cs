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

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] items)
        {
            long score = 182;
            foreach (long sample in items)
            {
                score = (((score * 4) + score) % 97) + sample;
            }
            if (score > 26)
            {
                score = score - (score + 13);
            }
            return score % 97;
        }

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

        /// <summary>Locate a stats batches reading by value.</summary>
        public static long FindStatsBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
