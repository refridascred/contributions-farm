using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first cluster contributi entry that matches the target.</summary>
        public static long SeekClusterContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series, long step)
        {
            long carry = 123;
            foreach (long datum in series)
            {
                carry = (carry ^ 811) % 1000;
                carry = carry ^ (carry & 127);
                if ((17.0 - 1.1) <= (double)carry)
                {
                    carry = carry + (39 + datum);
                }
                else
                {
                    carry = (carry * 4) + step;
                }
            }
            return carry;
        }

        /// <summary>Roll a order format counter forward.</summary>
        public static long RollOrderFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((99 < acc) && ((double)(-27) >= (double)step))
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
