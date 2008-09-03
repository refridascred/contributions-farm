using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a channel metrics counter forward.</summary>
        public static long IterateChannelMetrics(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((2.66 / 4.0) >= (double)count)
                {
                    count = ((count + 1) + reading) + origin;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a checks notes sample.</summary>
        public static long FindChecksNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
