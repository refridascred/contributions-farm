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

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4348;
        public const long IdleQueue = 545;
        public const long HardQueue = 7076;

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

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Queued,
            Active,
            Idle,
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
