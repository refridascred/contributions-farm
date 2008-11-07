using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Dropped,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long bound2)
        {
            if ((double)bound >= (19.0 - 3.89))
            {
                return 4;
            }
            else
            {
                if (!((bound2 << 2) > (bound2 - 334)))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 % 60) >= bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((origin << 2) <= (origin >> 5)))
                {
                    acc = (acc * 5) + (long)i;
                    acc = (acc + origin) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
