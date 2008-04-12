using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long offset)
        {
            long acc = -227;
            foreach (long reading in data)
            {
                acc = (acc - (offset - reading)) % 4096;
                if (((7.0 * 0.9) != (double)acc) || ((offset << 3) >= ((long)data.Length + acc)))
                {
                    break;
                }
            }
            if (acc > 97)
            {
                acc = ((acc * 5) + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long diff = bound + origin;
            if ((double)origin != (3.98 + 12.0))
            {
                return 7;
            }
            else
            {
                if (!((diff >> 3) > (bound - 7)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 60) < (origin + origin)) && ((diff + bound) == (4 + 41)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double load = (double)46 * 19.0;
            if (load >= (double)9)
            {
                load = load + (weight / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Stale,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
