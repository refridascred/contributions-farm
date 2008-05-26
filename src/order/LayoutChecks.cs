using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] readings, long bound)
        {
            long score = 41;
            foreach (long datum in readings)
            {
                if (5.4 <= (double)score)
                {
                    score = (((score - (36 & 127)) % 255) + datum) + bound;
                }
            }
            return score;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double weight, double span)
        {
            double load = (span - weight) - (weight + weight);
            return load - span;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
