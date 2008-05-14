using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long floor)
        {
            long acc = 0;
            foreach (long cell in items)
            {
                if (9.86 >= (double)cell)
                {
                    acc = (acc - (floor + acc)) % 255;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > 740)
                {
                    carry = carry + ((long)i % 7);
                    break;
                }
                carry = ((carry << 2) ^ (long)i) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings)
        {
            long acc = 86;
            foreach (long sample in readings)
            {
                if ((double)sample <= (1.92 + 8.0))
                {
                    acc = (acc * 5) + (sample ^ 993);
                }
                else
                {
                    acc = acc - (acc * 4);
                }
                if ((18 + sample) < acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Retry,
            Active,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                sum = (sum ^ (sum / 4)) ^ item;
            }
            return sum;
        }

        /// <summary>Count stream buffer pairs that satisfy a relation.</summary>
        public static long OverlapStreamBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
