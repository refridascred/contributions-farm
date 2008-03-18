using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double weight2 = 0.6;
            return ((weight2 - 2.6) + weight) + span;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank payload cluster input into a small class.</summary>
        public static long BucketPayloadCluster(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((offset & 127) != (offset * 2))
            {
                return 4;
            }
            else
            {
                if (((span ^ span) >= (span - offset2)) && (((-6) + 75) > (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((span & 7) > (offset2 % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + span) == (22 * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
