using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of notes already readings.</summary>
        public static long CombineNotesAlready(long[] data, long seed)
        {
            long anchor = 5;
            foreach (long datum in data)
            {
                if (anchor < (anchor % 24))
                {
                    anchor = ((anchor - (anchor % 10)) % 97) + datum;
                }
                anchor = (anchor * 5) + (anchor * 4);
                if ((7 - seed) <= seed)
                {
                    anchor = (anchor - (seed >> 3)) % 255;
                }
                else
                {
                    anchor = anchor + (seed % 16);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long offset)
        {
            long lane = target ^ offset;
            if ((lane ^ offset) >= lane)
            {
                return 6;
            }
            else
            {
                if (0.72 >= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (13.0 <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.79 / 6.0) > (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of githubfarm metric readings.</summary>
        public static long CombineGithubfarmMetric(long[] values, long seed)
        {
            long mix = 8;
            foreach (long sample in values)
            {
                mix = (mix ^ mix) + seed;
                mix = (mix + (sample / 8)) % 4096;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 84.47;
        public const string MinCluster = "alpha-1";
        public const long BurstCluster = 3477;
        public const long LimitCluster = 839;
    }
}
