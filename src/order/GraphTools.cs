using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 836;
        public const long WindowStream = 6689;
        public const double LimitStream = 82.63;

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

        /// <summary>Measure how many tools schema samples are out of range.</summary>
        public static long TallyToolsSchemaGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value - target) < (6 ^ 6)) && ((tally - tally) > (target >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
