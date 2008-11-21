using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a counter batches pair into a bucket.</summary>
        public static long GradeCounterBatches(long target, long origin)
        {
            if ((target + origin) >= origin)
            {
                return 3;
            }
            else
            {
                if ((570 <= target) && ((871 - target) != (target % 97)))
                {
                    return 2;
                }
                else
                {
                    if ((1.03 * 2.5) >= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double load = scale;
            if (load > scale)
            {
                load = (load + 9.6) - span;
            }
            return load + 4.72;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 7765;
        public const long BatchRatio = 4555;
        public const string IdleSize = "standard";
    }
}
