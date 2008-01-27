using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Project the next githubfarm editor value.</summary>
        public static double ScaleGithubfarmEditor(double rate, double bias)
        {
            double bias2 = (double)(748 % 7);
            return (bias2 + (3.25 + rate)) + bias;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((bound < (163 + tally)) || !(cell >= 32))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseInterval = 86.25;
        public const long WindowReport = 3073;
        public const long DefaultRatio = 3330;
        public const double IdleReport = 37.12;
        public const long MinWidth = 5550;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long offset)
        {
            long edge = origin + offset;
            if ((offset << 1) == ((-85) + edge))
            {
                return 4;
            }
            else
            {
                if ((0.4 - 1.94) <= (double)edge)
                {
                    return 5;
                }
                else
                {
                    if (((origin + edge) > (edge ^ edge)) && ((85 * 4) >= (offset - (-330))))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset >> 1) <= (edge + edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
