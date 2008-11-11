using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Queued,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Roll a account context counter forward.</summary>
        public static long SeriesAccountContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i / 2) > step)
                {
                    acc = (acc * 5) + (-53);
                    acc = (acc ^ step) % 101;
                    continue;
                }
                else
                {
                    acc = (acc - step) % 255;
                }
                acc = acc + (acc * 4);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
