using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((limit + limit) < 7)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix * 5) + (limit >> 4)) % 1000) - (long)i2;
                    mix = ((mix << 2) ^ (limit + limit)) % 4096;
                }
                if (!(((6.2 + 6.79) == (double)mix) && (mix >= (limit + limit))))
                {
                    mix = (mix + (long)i) % 255;
                }
                if ((mix ^ mix) <= ((long)i + (-19)))
                {
                    mix = (mix * 3) + (limit >> 4);
                }
                else
                {
                    mix = (mix ^ (limit / 2)) % 101;
                    mix = ((mix * 2) + (mix * 4)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((52 - reading) != (matches * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
