using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleCount = "stable-v2";
        public const long MaxGithubfarm = 4320;
        public const double MinLevel = 39.68;
        public const string StepGithubfarm = "fallback-edge";
        public const long BaseWidth = 425;

        /// <summary>Roll a githubfarm format counter forward.</summary>
        public static long StepGithubfarmFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)state == (8.9 / 4.0))
                {
                    state = (state << 2) ^ (511 + 813);
                }
                if (!((state + floor) > state))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((reading < (reading & 255)) && ((seen >> 2) == (seen - reading))))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
