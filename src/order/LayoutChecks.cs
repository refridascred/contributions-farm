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

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
