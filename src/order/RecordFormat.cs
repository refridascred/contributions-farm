using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of notes graph entries.</summary>
        public static long DigestNotesGraph(long[] data, long bound)
        {
            long carry = -94;
            foreach (long sample in data)
            {
                carry = (((carry << 3) ^ (sample - sample)) % 255) - bound;
            }
            if (carry > 972)
            {
                carry = ((carry << 3) ^ (carry / 9)) % 101;
            }
            return carry;
        }

        /// <summary>Combine contributi token values into a single score.</summary>
        public static long WeighContributiToken(long[] series)
        {
            long anchor = -5;
            foreach (long cell in series)
            {
                anchor = anchor - (4 >> 1);
                if (!((double)cell < (9.27 + 8.87)))
                {
                    break;
                }
            }
            if (anchor < 60)
            {
                anchor = (anchor - (anchor % 64)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long target, long seed)
        {
            if ((0.88 - 8.1) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((10.0 / 5.0) != (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (seed < (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((matches * 4) >= (entry & 7)) || ((9.32 * 7.0) <= 3.26)) || !((entry % 3) >= 426))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
