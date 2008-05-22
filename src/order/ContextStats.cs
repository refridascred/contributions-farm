using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate command record readings against a bound.</summary>
        public static bool CheckCommandRecordRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two already githubfarm measurements.</summary>
        public static double ScaleAlreadyGithubfarm(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= (floor + 9.1))
            {
                weight2 = weight2 + 0.4;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 - (weight2 - weight);
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= 6)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
