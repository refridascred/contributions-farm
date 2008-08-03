using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSpan = 8463;
        public const long BatchBuffer = 7612;
        public const long LimitBuffer = 1749;
        public const long MinSize = 8484;

        /// <summary>Iterate the record graph series from a seed.</summary>
        public static long StepRecordGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (((double)step < (double)anchor) || ((6.5 * 12.0) >= (double)step))
                {
                    anchor = anchor ^ (long)i;
                }
                if ((((long)i >> 5) < (anchor ^ 4)) && (1 <= step))
                {
                    anchor = anchor + ((long)i >> 3);
                    anchor = (anchor << 3) ^ step;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
