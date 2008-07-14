using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Active,
            Closed,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double weight = rate;
            if (weight <= weight)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (weight / 8.0);
            }
            return weight + weight;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double gain, double span)
        {
            double scale = 4.27;
            if (scale < (double)720)
            {
                scale = scale + 8.3;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 4585;
        public const double BurstNotes = 75.73;
        public const long DefaultBudget = 6028;
        public const string StepNotes = "open-1";
        public const long LimitInterval = 9288;
    }
}
