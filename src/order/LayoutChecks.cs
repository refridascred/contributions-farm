using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long AuditGithubfarmFilterMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) != (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metric already input into a small class.</summary>
        public static long RankMetricAlready(long step, long floor)
        {
            long lane = step ^ floor;
            if (!((lane << 1) < (step % 64)))
            {
                return 7;
            }
            else
            {
                if ((((-51) / 2) < step) || ((double)floor >= (8.8 * 1.21)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up cluster schema samples.</summary>
        public static long OverlapClusterSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache command value from a seed.</summary>
        public static long StepCacheCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((limit << 2) == (state * 4))
                {
                    state = (state * 3) + (limit ^ (-9));
                }
                else
                {
                    state = (state ^ (9 * 2)) % 1000;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state - (state & 7)) % 101;
                    state = (state ^ ((long)i2 << 1)) % 97;
                }
                if (state < (long)i)
                {
                    state = (state - (state & 127)) % 1000;
                    state = (state * 3) + state;
                }
                else
                {
                    state = state - (state - state);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
