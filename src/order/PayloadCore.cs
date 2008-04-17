using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (anchor + target)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double rate = floor;
            if (rate < (17.0 - rate))
            {
                rate = (rate + floor) + weight;
            }
            return rate + floor;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
