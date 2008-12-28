using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long step)
        {
            long lane = offset ^ step;
            if (((offset / 8) != (1 >> 4)) || (55 < (step - 940)))
            {
                return 0;
            }
            else
            {
                if (((lane - offset) > (lane ^ lane)) && ((offset << 2) >= (offset % 60)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a editor checks counter forward.</summary>
        public static long StepEditorChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((double)acc != (3.5 * 3.8))
                {
                    acc = (acc ^ (acc - seed)) % 97;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Ready,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((14 > (count << 3)) && (((value << 1) == (value % 64)) || ((count % 3) <= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
