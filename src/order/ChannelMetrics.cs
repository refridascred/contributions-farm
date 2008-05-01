using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long offset, long offset2)
        {
            long delta = offset - offset2;
            if (((7.0 + 20.0) <= (double)offset2) || (82 <= (5 + offset2)))
            {
                return 0;
            }
            else
            {
                if (((offset + 954) <= offset) && ((offset ^ delta) >= offset2))
                {
                    return 8;
                }
                else
                {
                    if (!((417 + 51) != (delta - (-1))))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)delta < (9.83 + 1.3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine context buffer values into a single score.</summary>
        public static long ScoreContextBuffer(long[] values, long bound)
        {
            long result = -234;
            foreach (long item in values)
            {
                if (bound <= (item + result))
                {
                    result = (result ^ ((-7) << 3)) % 97;
                }
                else
                {
                    result = (result ^ (128 + 23)) % 65521;
                }
            }
            return result % 97;
        }
    }
}
