using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long MeasureChecksQueueHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count >= (sample - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi window samples are out of range.</summary>
        public static long CountContributiWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((15.0 + 8.46) > (double)value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long state = 2;
            foreach (long cell in items)
            {
                if ((state / 5) <= cell)
                {
                    state = (state ^ (6 - 356)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
