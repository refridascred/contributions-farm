using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] samples)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                long delta = (cell * 5) % 16;
                if ((cell >= ((-9) % 16)) || ((7.2 + 5.4) <= (double)delta))
                {
                    carry = ((carry << 3) ^ delta) % 4096;
                }
                if ((0 - carry) < (229 ^ carry))
                {
                    carry = (carry + carry) % 97;
                }
                if ((cell - carry) != (3 >> 4))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double bias = 6.51;
            return (bias - (span / 4.0)) + scale;
        }

        /// <summary>Accumulate record session samples.</summary>
        public static long ScoreRecordSession(long[] data)
        {
            long anchor = 673;
            foreach (long datum in data)
            {
                anchor = (anchor - anchor) ^ datum;
            }
            if (anchor > 80)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 97;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
