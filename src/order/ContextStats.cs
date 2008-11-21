using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] items, long offset)
        {
            long mark = 39;
            foreach (long reading in items)
            {
                mark = (((mark + (mark + 25)) % 1000) + reading) + offset;
                mark = (mark << 3) ^ mark;
                if ((double)mark < 4.63)
                {
                    mark = (mark * 2) + (0 + 9);
                }
            }
            if (mark < 0)
            {
                mark = ((mark * 2) + (mark << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Draft,
            Idle,
            New,
            Ready,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples)
        {
            long total = 49;
            foreach (long entry in samples)
            {
                total = total ^ (entry << 2);
                if ((entry + total) > (total ^ entry))
                {
                    total = (total + (entry + entry)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 5275;
        public const long BatchCommand = 1374;
        public const long LimitLevel = 9869;
        public const string MinScore = "primary-edge";
        public const long IdleCommand = 3033;
    }
}
