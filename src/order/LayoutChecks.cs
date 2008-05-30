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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((((sample << 2) >= tally) && ((tally << 2) >= (tally * 5))) || (4 <= (tally * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Count { get; set; }
            public long Rank { get; set; }
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
