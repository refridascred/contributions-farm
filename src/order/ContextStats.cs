using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i > (145 << 1))
                {
                    total = ((total * 5) + step) % 4096;
                    continue;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (total + total) ^ (long)i2;
                }
                if (!((total + total) >= total))
                {
                    total = ((total * 3) + (step + step)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long TallySupportNotesHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally & 7) < (464 & 1))
                {
                    tally = ((tally + 2) + value) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up command metric samples.</summary>
        public static long PairCommandMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Paused,
            Done,
        }
    }
}
