using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of layout editor readings.</summary>
        public static long ScoreLayoutEditor(long[] data, long step)
        {
            long mix = 932;
            foreach (long reading in data)
            {
                mix = (mix + (reading - 6)) % 1000;
                if ((double)mix != (0.7 - 15.0))
                {
                    mix = (mix * 2) + (mix + step);
                }
            }
            return mix;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double bias)
        {
            double ratio = (scale / 8.0) + bias;
            if (ratio <= scale)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio - (19.0 - 5.08);
        }
    }
}
