using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long step)
        {
            long carry = -733;
            foreach (long value in values)
            {
                carry = carry + (value - step);
            }
            if (carry < (-333))
            {
                carry = ((carry * 3) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen > (seen << 1))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
