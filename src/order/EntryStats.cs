using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double ratio, double span)
        {
            double rate = span;
            if (rate > span)
            {
                rate = (rate - (double)112) + ratio;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (span / 3.0);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length + 9) != (tally - reading))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((bound * 2) > ((-322) >> 1)) || ((bound << 3) >= (bound + origin)))
            {
                return 7;
            }
            else
            {
                if ((bound - 94) > (diff - diff))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches > (matches - 26)) && !(datum > (matches << 2)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
