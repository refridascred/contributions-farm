using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up support counter samples.</summary>
        public static long CompareSupportCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm already readings.</summary>
        public static long CombineGithubfarmAlready(long[] data)
        {
            long carry = 10;
            foreach (long reading in data)
            {
                if ((double)carry >= 7.63)
                {
                    carry = (((carry << 3) ^ (carry ^ carry)) % 4096) - reading;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 255;
                }
            }
            if (carry > 0)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series, long floor)
        {
            long result = 86;
            foreach (long value in series)
            {
                if ((double)value == (13.0 + 7.0))
                {
                    result = ((result * 2) + (3 % 100)) % 255;
                }
                if (((floor / 9) > ((-403) + 31)) || ((floor + value) <= (87 * 5)))
                {
                    result = (result ^ (floor - value)) % 97;
                }
            }
            if (result < 160)
            {
                result = result + (result << 2);
            }
            return result;
        }
    }
}
