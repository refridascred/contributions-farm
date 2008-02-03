using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleLevel = 4213;
        public const long MaxCluster = 3883;
        public const long StepWidth = 1693;
        public const string LimitCluster = "cached-v2";
        public const double MaxFactor = 77.48;

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ score;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (double)(-937)) + (double)(long)i) - floor;
            }
            return scale - 2.08;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "strict";
        public const long DefaultLevel = 3219;
        public const long WindowProfile = 903;
        public const string StepProfile = "strict-1";
        public const double DefaultProfile = 69.51;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long bound)
        {
            if (!(bound >= (step << 3)))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
