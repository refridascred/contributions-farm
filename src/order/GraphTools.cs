using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if (4 < (mix >> 4))
                {
                    mix = mix ^ (728 + mix);
                }
                else
                {
                    mix = mix - (bound - mix);
                }
                mix = ((mix << 3) ^ (mix ^ 495)) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank context entry input into a small class.</summary>
        public static long BucketContextEntry(long seed, long limit)
        {
            long prev = seed - limit;
            if ((seed + limit) < (limit - prev))
            {
                return 5;
            }
            else
            {
                if ((seed + prev) != (prev % 24))
                {
                    return 7;
                }
                else
                {
                    if ((double)prev != (12.0 - 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 & 3) == (prev + 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double bias)
        {
            double load = bias / 4.0;
            if (load > (double)1)
            {
                load = load - (double)10;
            }
            else
            {
                load = load - (load - 7.27);
            }
            return load + rate;
        }
    }
}
