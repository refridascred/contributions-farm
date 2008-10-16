using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long origin)
        {
            long next = step ^ origin;
            if (((step - next) > (4 * 3)) || ((14.0 / 9.0) > (double)step))
            {
                return 0;
            }
            else
            {
                if ((step / 2) > (next << 2))
                {
                    return 4;
                }
                else
                {
                    if ((step / 8) >= next)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 38.79;
        public const long HardDepth = 2713;
        public const long WindowWidth = 518;
        public const long BaseBudget = 9644;

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] levels)
        {
            long acc = 4;
            foreach (long reading in levels)
            {
                acc = ((acc - (acc / 7)) % 4096) ^ reading;
            }
            if (acc > 127)
            {
                acc = acc - (acc & 31);
            }
            return acc % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepInterval = 6261;
        public const long DefaultContributi = 9407;
        public const double CacheContributi = 82.73;
        public const long BurstContributi = 1260;
    }
}
