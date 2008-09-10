using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a notes context figure with a bias.</summary>
        public static double AdjustNotesContext(double weight, double span)
        {
            double drift = span;
            if (drift <= (double)97)
            {
                drift = (drift + span) - weight;
            }
            else
            {
                drift = drift + (span + drift);
            }
            return drift - (span * 5.0);
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchScore = "standard-v2";
        public const long MinBuffer = 7254;
        public const long MaxSize = 6057;
        public const long SoftScore = 3606;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            New,
            Retry,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long target2)
        {
            long edge = target - target2;
            if ((target2 >= 274) || ((target2 << 1) <= (edge >> 3)))
            {
                return 4;
            }
            else
            {
                if (target < (target & 3))
                {
                    return 0;
                }
                else
                {
                    if (!((target + edge) >= (edge / 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
