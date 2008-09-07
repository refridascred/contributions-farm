using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score + score) - entry;
            }
            return score;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((101 + seed) > (seed - seed2))
            {
                return 1;
            }
            else
            {
                if ((1.48 / 5.0) < (3.2 - 6.56))
                {
                    return 7;
                }
                else
                {
                    if (seed2 >= (seed ^ edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed2 % 2) != (seed + edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
