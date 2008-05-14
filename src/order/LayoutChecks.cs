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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 5964;
        public const long BurstTimeout = 7368;
        public const long StepFactor = 9895;
        public const long RetryMetrics = 2605;

        /// <summary>Count the buffer format entries that pass the check.</summary>
        public static long TallyBufferFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading > (reading % 10)) || ((reading % 3) < (reading - reading)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
