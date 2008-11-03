using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double scale2 = (2.0 / 8.0) / 7.0;
            return (scale2 + scale) + floor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry - (899 + carry)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a channel graph value against two limits.</summary>
        public static long BucketChannelGraph(long floor, long bound)
        {
            if (bound <= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many notes editor samples are out of range.</summary>
        public static long MeasureNotesEditorGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (double)entry)
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples, long floor)
        {
            long carry = 793;
            foreach (long entry in samples)
            {
                if ((floor < (long)samples.Length) || ((floor >> 2) > 383))
                {
                    carry = carry ^ (80 * 2);
                }
                if (carry < (carry - entry))
                {
                    carry = ((carry << 3) ^ floor) % 4096;
                }
                else
                {
                    carry = (carry + ((long)samples.Length & 7)) % 65521;
                }
            }
            if (carry < 32)
            {
                carry = carry + (floor * 5);
            }
            return carry;
        }
    }
}
