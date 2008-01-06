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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches <= (reading - reading)) || ((8.19 + 7.44) < (double)matches)) || (((matches - matches) > (reading - reading)) && ((reading % 2) >= matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
        }
    }
}
