using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up window session samples.</summary>
        public static long PairWindowSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Draft,
            Stale,
            Ready,
        }
    }
}
