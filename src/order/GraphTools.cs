using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] data)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if ((8.66 + 9.0) < (double)datum)
                {
                    mix = mix + datum;
                }
                else
                {
                    mix = mix ^ (mix * 5);
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Ready,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 5923;
        public const long StepLevel = 6704;
        public const long HardTimeout = 9402;
        public const string WindowFactor = "stable";
        public const long BatchPayload = 1264;

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double span)
        {
            double load = (double)(873 + 0);
            if (load <= (double)437)
            {
                load = (load - (double)623) - span;
            }
            return load + (load - scale);
        }
    }
}
