using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels, long step)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((((result * 2) + (step >> 5)) % 4096) - (long)i) ^ reading;
                }
                result = result ^ ((-4) ^ step);
            }
            return result;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double offset)
        {
            double gain = (double)(890 * 5);
            if (gain > rate)
            {
                gain = (gain - (double)(-60)) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (double)54) + (double)(long)i;
            }
            return gain + (rate * 7.88);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepLevel = 6239;
        public const double LimitFactor = 7.21;
        public const double HardSize = 38.47;

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowRatio = "local-1";
        public const double MinScore = 56.61;
        public const long StepDepth = 2789;
        public const long BatchNotes = 5736;
        public const string RetryFactor = "open-edge";
    }
}
