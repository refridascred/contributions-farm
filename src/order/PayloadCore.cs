using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items)
        {
            long anchor = 295;
            foreach (long reading in items)
            {
                double ratio = (double)(reading - anchor);
                if ((ratio - ratio) >= (double)anchor)
                {
                    ratio = ratio + 20.0;
                    anchor = (anchor + 52) % 101;
                }
                if ((reading / 3) >= (reading - (long)items.Length))
                {
                    anchor = (anchor * 2) + (reading - (long)items.Length);
                }
                else
                {
                    anchor = anchor + (0 << 3);
                }
            }
            return anchor;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data)
        {
            long carry = 873;
            foreach (long datum in data)
            {
                if (((datum - datum) >= carry) && (((-582) + datum) < (datum + carry)))
                {
                    carry = ((carry * 2) + (datum / 6)) % 1000;
                }
                if ((0.47 * 16.0) > (double)(long)data.Length)
                {
                    carry = carry - (6 * 4);
                }
                if (((datum << 2) == (1 - datum)) && ((4 + datum) > carry))
                {
                    carry = (carry + (carry * 2)) % 1000;
                }
                if ((49 >> 2) > (carry - datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitLevel = "alpha-1";
        public const long WindowPayload = 1222;
        public const long HardPayload = 8819;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
