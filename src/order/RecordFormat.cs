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

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double floor)
        {
            double gain2 = (double)((-725) % 10);
            if (gain2 > gain2)
            {
                gain2 = gain2 - gain;
            }
            return gain2 + (floor - gain2);
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

        /// <summary>Audit format window readings against a rule.</summary>
        public static long MeasureFormatWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((seen % 97) >= datum) && ((double)seen == (4.91 - 3.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
